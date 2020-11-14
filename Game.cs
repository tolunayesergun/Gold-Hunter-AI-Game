using GoldHunterAIGame.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GoldHunterAIGame
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        public static int areaXSize = 10;   // Oyunda ki bir satırda ki kare sayısı
        public static int areaYSize = 10;   // Oyunda ki bir stunda ki kare sayısı
        public static int goldRate = 20;    // Oyunda ki karelin % kaçının altın olduğunu tutan statik değişken
        public static int secretGoldRate = 10;  // Oyunda ki karelin % kaçının gizli altın olduğunu tutan statik değişken
        public static int turnMoveMAX = 3;  // Bir oyuncunun max hamle sayısını tutan statik değişken

        public static int MoveNextTargetTEMP = 0;  // Gidilicek sonra ki hedefi tutan temp değişken, Buton numarası olarak hedef alıyor.
        public static Button playerButtonTEMP;   // Sırada ki oyuncuyu tutan temp değişken, "A","B","C","D" olarak değer alıyor
        public static int turnMoveTEMP = 1;     // Sırası gelen oyuncunun hamle sayısını tutan temp değişken

        public static string[] playerTurnList = { "A", "B", "C", "D" };  // Oyuncuların sırasını tutan statik Dizi
        public static int[] targetList = { 25, 5, 6, 7 };  // Oyuncuların sonraki hedeflerini tutan statik dizi
        private static List<Gold> goldList = new List<Gold>();

        private void Game_Load(object sender, EventArgs e)
        {
            CreateBoard();
            TurnTimer.Start();
        }

        #region GlobalFunctions

        private int FindButtonNumber(Cordinant map)
        {
            int result = ((map.row - 1) * areaXSize + map.column);
            return result;
        }   // satır ve stun bilgisi verilen butonun Numarasını veriyor.

        private Cordinant FindCordinant(int buttonNumber)
        {
            Cordinant map = new Cordinant
            {
                row = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(buttonNumber) / Convert.ToDouble(areaXSize)))
            };
            int rowLimit = map.row * areaXSize;
            map.column = areaXSize - (rowLimit - buttonNumber);
            return map;
        }  // Numarası verilen butonun satır ve stun bilgisini veriyor.

        #endregion GlobalFunctions

        #region GameDynamics

        public static int playerTurn = 0;  // Sıranın hangi oyuncuda olduğunu tutuyor.

        private void TurnTimer_Tick(object sender, EventArgs e)   // Oyun sırasını hareketlendiren timer
        {
            if (MoveTimer.Enabled == false)
            {
                if (playerTurn == 4) playerTurn = 0;
                turnMoveTEMP = 1;
                NextMove(playerTurnList[playerTurn], targetList[playerTurn]);
                playerTurn++;
            }
        }

        private void NextMove(string player, int target)
        {
            switch (player)
            {
                case "A":
                    playerButtonTEMP = playerA;
                    MoveNextTargetTEMP = target;
                    MoveTimer.Start();
                    break;

                case "B":
                    playerButtonTEMP = playerB;
                    MoveNextTargetTEMP = target;
                    MoveTimer.Start();
                    break;

                case "C":
                    playerButtonTEMP = playerC;
                    MoveNextTargetTEMP = target;
                    MoveTimer.Start();
                    break;

                case "D":
                    playerButtonTEMP = playerD;
                    MoveNextTargetTEMP = target;
                    MoveTimer.Start();
                    break;

                default:
                    break;
            }
        }  // Sonraki hamleyi timer'a yollayan fonksiyon.

        private void moveTo(Button player, int target)
        {
            Cordinant startSpot = FindCordinant(Convert.ToInt32(player.AccessibleName)), endSpot = FindCordinant(target);

            if (startSpot.row < endSpot.row)
            {
                startSpot.row++;
                player.Location = (pnlBoard.Controls["btn" + (Convert.ToInt32(player.AccessibleName) + areaXSize)] as Button).Location;
                player.AccessibleName = (Convert.ToInt32(player.AccessibleName) + areaXSize).ToString();
            }
            else if (startSpot.row > endSpot.row)
            {
                startSpot.row--;
                player.Location = (pnlBoard.Controls["btn" + (Convert.ToInt32(player.AccessibleName) - areaXSize)] as Button).Location;
                player.AccessibleName = (Convert.ToInt32(player.AccessibleName) - areaXSize).ToString();
            }
            else if (startSpot.column < endSpot.column)
            {
                startSpot.column++;
                player.Location = (pnlBoard.Controls["btn" + (Convert.ToInt32(player.AccessibleName) + 1)] as Button).Location;
                player.AccessibleName = (Convert.ToInt32(player.AccessibleName) + 1).ToString();
            }
            else if (startSpot.column > endSpot.column)
            {
                startSpot.column--;
                player.Location = (pnlBoard.Controls["btn" + (Convert.ToInt32(player.AccessibleName) - 1)] as Button).Location;
                player.AccessibleName = (Convert.ToInt32(player.AccessibleName) - 1).ToString();
            }

            if (Convert.ToInt32(player.AccessibleName) == target) MoveTimer.Stop();
        } // Sonraki hamleyi gerçekleştiren fonksiyon, Oyuncu ve hedef seçimi yapılması yeterli

        private void MoveA_Tick(object sender, EventArgs e)
        {
            if (turnMoveTEMP == turnMoveMAX) MoveTimer.Stop();
            moveTo(playerButtonTEMP, MoveNextTargetTEMP);
            turnMoveTEMP++;
        }  // Oyuncu hareketlerini sürdüren timer

        #endregion GameDynamics

        #region InterfaceFunctions
        Random rnd = new Random();

        public int getRandomValue()
        {
          
            int nextValue;

            nextValue = 5 * rnd.Next(5 / 5, 20 / 5);

            return nextValue;
        }

        private void CreateBoard()
        {
            pnlBoard.Controls.Clear();

            if (MoveTimer.Enabled == true) MoveTimer.Stop();
            if (TurnTimer.Enabled == true) TurnTimer.Stop();
            goldList.Clear();

            int areaTotalSize = areaXSize * areaYSize;   // Oyun alanında ki toplam kare sayısı
            int cellWidth = Convert.ToInt32(Math.Floor(Convert.ToDouble(pnlBoard.Width) / areaXSize));  // Alandaki Bir karenin genişliği
            int cellHeight = Convert.ToInt32(Math.Floor(Convert.ToDouble(pnlBoard.Height) / areaYSize)); // Alandaki Bir karenin uzunluğu

            int playerAFirstSpawn = 1;
            int playerBFirstSpawn = areaXSize;
            int playerCFirstSpawn = areaTotalSize;
            int playerDFirstSpawn = areaTotalSize - (areaXSize - 1);

            //Altınlar için rasgele yer türetiyoruz.
            GenerateGolds(areaTotalSize, playerAFirstSpawn, playerBFirstSpawn, playerCFirstSpawn, playerDFirstSpawn);

            int ButtonCount = 0;
            int x = 0, y = 0;
            for (int i = 0; i < areaTotalSize; i++)
            {
                Bitmap tempImage = new Bitmap(Properties.Resources.Dirt);
                Gold tempGold = goldList.Where(p => p.buttonNum == +i).SingleOrDefault();

                if (tempGold != null)
                {
                    switch (tempGold.value)
                    {
                        case 5:
                            if (!tempGold.isSecret) tempImage = Properties.Resources.Gold5;
                            break;

                        case 10:
                            if (!tempGold.isSecret) tempImage = Properties.Resources.Gold10;
                            break;
                   
                        case 15:
                            if (!tempGold.isSecret) tempImage = Properties.Resources.Gold15;
                            break;

                        case 20:
                            if (!tempGold.isSecret) tempImage = Properties.Resources.Gold20;
                            break;
                    }
                }

                Button btn = new Button
                {
                    Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                    Size = new System.Drawing.Size(cellWidth, cellHeight),
                    BackColor = Color.White,
                    Text = (i + 1).ToString(),
                    Name = "btn" + (i + 1),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackgroundImage = tempImage,
                    Enabled = false
                };

                if (ButtonCount < areaXSize)
                {
                    btn.Location = new Point(x, y);
                    pnlBoard.Controls.Add(btn);
                    x += cellWidth;
                    ButtonCount++;
                }
                else
                {
                    ButtonCount = 1;
                    x = 0;
                    y += cellHeight;
                    btn.Location = new Point(x, y);
                    pnlBoard.Controls.Add(btn);
                    x += cellWidth;
                }
            }

            pnlBoard.Controls.Add(playerA);
            playerA.BringToFront();
            playerA.Size = new System.Drawing.Size(cellWidth, cellHeight);
            playerA.Location = (pnlBoard.Controls["btn" + playerAFirstSpawn.ToString()] as Button).Location;
            playerA.AccessibleName = playerAFirstSpawn.ToString();

            pnlBoard.Controls.Add(playerB);
            playerB.BringToFront();
            playerB.Size = new System.Drawing.Size(cellWidth, cellHeight);
            playerB.Location = (pnlBoard.Controls["btn" + playerBFirstSpawn.ToString()] as Button).Location;
            playerB.AccessibleName = playerBFirstSpawn.ToString();

            pnlBoard.Controls.Add(playerC);
            playerC.BringToFront();
            playerC.Size = new System.Drawing.Size(cellWidth, cellHeight);
            playerC.Location = (pnlBoard.Controls["btn" + playerCFirstSpawn.ToString()] as Button).Location;
            playerC.AccessibleName = playerCFirstSpawn.ToString();

            pnlBoard.Controls.Add(playerD);
            playerD.BringToFront();
            playerD.Size = new System.Drawing.Size(cellWidth, cellHeight);
            playerD.Location = (pnlBoard.Controls["btn" + playerDFirstSpawn.ToString()] as Button).Location;
            playerD.AccessibleName = playerDFirstSpawn.ToString();
        }    // Oyun sahasını oluşturan fonksiyon

        private void GenerateGolds(int areaTotalSize, int playerAFirstSpawn, int playerBFirstSpawn, int playerCFirstSpawn, int playerDFirstSpawn)
        {
            int spawnedTotalGold = 1;
            int goldIterator = 0;
            int totalGoldCount = (areaTotalSize * goldRate) / 100; // Alandaki Toplam Altın Sayısı
            int totalSecretGoldCount = (areaTotalSize * secretGoldRate) / 100; // Alandaki Toplam Gizli Altın Sayısı
            int[] goldSpawns = new int[totalGoldCount]; // Alandaki altınların yeri (Buton numarası olarak)
            int[] secretGoldSpawns = new int[totalSecretGoldCount]; // Alandaki altınların yeri (Buton numarası olarak)

            while (goldIterator < totalGoldCount)
            {
                int nextNumber = rnd.Next(areaTotalSize);
                if (nextNumber != playerAFirstSpawn - 1 && nextNumber != playerBFirstSpawn - 1 && nextNumber != playerCFirstSpawn - 1 && nextNumber != playerDFirstSpawn - 1)
                {
                    if (!(goldSpawns.Contains(nextNumber)))
                    {
                        goldSpawns[goldIterator] = nextNumber;
                        goldList.Add(new Gold { goldID = spawnedTotalGold, isSecret = false, pozition = FindCordinant(nextNumber + 1), button = "btn" + (nextNumber + 1).ToString(), value = getRandomValue(), buttonNum = nextNumber });
                        spawnedTotalGold++;
                        goldIterator++;
                    }
                }
            }

            //Gizli Altınlar için rasgele yer türetiyoruz.
            goldIterator = 0;
            while (goldIterator < totalSecretGoldCount)
            {
                int nextNumber = rnd.Next(areaTotalSize);
                if (nextNumber != playerAFirstSpawn - 1 && nextNumber != playerBFirstSpawn - 1 && nextNumber != playerCFirstSpawn - 1 && nextNumber != playerDFirstSpawn - 1)
                {
                    if (!(goldSpawns.Contains(nextNumber)) && !(secretGoldSpawns.Contains(nextNumber)))
                    {
                        secretGoldSpawns[goldIterator] = nextNumber;
                        goldList.Add(new Gold { goldID = spawnedTotalGold, isSecret = true, pozition = FindCordinant(nextNumber + 1), button = "btn" + (nextNumber + 1).ToString(), value = getRandomValue(), buttonNum = nextNumber });
                        spawnedTotalGold++;
                        goldIterator++;
                    }
                }
            }
        }

        private void pnlBoard_Resize(object sender, EventArgs e)
        {
            CreateBoard();
        }   // Oyun ekranının değişmesi durumunda oyunun tekrardan oluşması için gerekli trigger

        #endregion InterfaceFunctions
    }
}