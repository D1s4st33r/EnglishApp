using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishApp
{
    public partial class MemoryGame : Form
    {
        int LevelStrart = 0,         //Nivel del juego
            numberImage = 0,         //
            numeroCartas = 0,        //aqui se almaccena el doble del numero de imagenes que se necesita en el nivel
            intento = 0,             //Cuenta el numero de click que se an dado
            contadorEncontradas = 0; // Cuenta el numero de cartas que se han encontrado
        static int contadorPar = 0, driver = 0;        // valo que solo puede llegar a 2 y se reinicia se usa para que no se permita volvear mas cartas ,solo en pares
          
        string[] Imagenes,           //nombre de las imagenes que se usan en el panel, se obtienen de la base de datos
                 datos;              //datos que se ponen para identificar los pares son el nombre de la imgen y el nombre del verbo(sin la extension)
        Button eleccionUno;
        string primeraVerb , imagenVerb,
                actual;

        Random rnd = new Random();
        int anchoPaneControl, altoPanelControl, altoPanelCartas, anchoPanelCartas;


        /// <summary>
        ///@Constructor
        /// </summary>
        /// <param nivelJuego="i"></param>
        public MemoryGame(int i)
        {
            InitializeComponent();
            PanelCartas.Hide(); // oculta el panel hasta que el juego inicie
            LevelStrart = i; // nivel
            this.WindowState = FormWindowState.Maximized; // meximizamos la pantalla
        }

        /// <summary>
        /// levelSetUp calcula el numero de filas y columnas por nivel y la cantidad de imagenes
        /// </summary>
        /// <param name="i"></param>
        /// <returns int[]="level"> 2 indices que se usan por el inicio del juego para pintar las filas y las columnas en el panel </returns>
        public int[] LevelSetUp(int i)
        {
            int[] level;    //regresa este array con el numero de las filas en la posicion 0 y colmnas posicion 1
            switch (i) {
                case 1:     //caso 1
                    level = new int[] { 2, 2 };
                    numberImage = (level[0] * level[1]) / 2;  //numero de cartas para el nivel 1
                    if (queryGames.Verbs() >= numberImage) //validacion de el numero de imagenes   
                    { Imagenes = queryGames.RandomVerbsImage(numberImage); }
                    else { MessageBox.Show("there are not enough verbs for this level"); }
                    return level;
                case 2:
                    level = new int[] { 3, 3 };
                    numberImage = (level[0] * level[1]) / 2;
                    if (queryGames.Verbs() >= numberImage)
                    { Imagenes = queryGames.RandomVerbsImage(numberImage); }
                    else { MessageBox.Show("there are not enough verbs for this level"); }
                    return level;
                case 3: 
                         level = new int[] { 4, 3 };
                        numberImage = (level[0] * level[1]) / 2;
                        if (queryGames.Verbs() >= numberImage)
                        { Imagenes = queryGames.RandomVerbsImage(numberImage); }
                        else { MessageBox.Show("there are not enough verbs for this level"); }
                        return level;
                case 4: 
                         level = new int[] { 4, 4 };
                        numberImage = (level[0] * level[1]) / 2;
                        if (queryGames.Verbs() >= numberImage)
                        { Imagenes = queryGames.RandomVerbsImage(numberImage); }
                        else { MessageBox.Show("there are not enough verbs for this level"); }
                        return level;
                case 5:
                     level = new int[] { 4, 5 };
                    numberImage = (level[0] * level[1]) / 2;
                    if (queryGames.Verbs() >= numberImage)
                    { Imagenes = queryGames.RandomVerbsImage(numberImage); }
                    else { MessageBox.Show("there are not enough verbs for this level"); }
                    return level;

                case 6:
                    level = new int[] { 5, 5 };
                    numberImage = (level[0] * level[1]) / 2;
                    if (queryGames.Verbs() >= numberImage)
                    { Imagenes = queryGames.RandomVerbsImage(numberImage);
                    }
                    else { MessageBox.Show("there are not enough verbs for this level"); }
                    return level;
                case 7:
                    level = new int[] { 5, 6 };
                    numberImage = (level[0] * level[1]) / 2;
                    if (queryGames.Verbs() >= numberImage)
                    { Imagenes = queryGames.RandomVerbsImage(numberImage);
                    }
                    else { MessageBox.Show("there are not enough verbs for this level"); }
                    return level;
                case 8:
                    level = new int[] { 6, 8 };
                    numberImage = (level[0] * level[1]) / 2;
                    if (queryGames.Verbs() >= numberImage)
                    { Imagenes = queryGames.RandomVerbsImage(numberImage);
                    }
                    else { MessageBox.Show("there are not enough verbs for this level"); }
                    return level;
                case 9:
                    level = new int[] { 8, 8 }; 
                     numberImage = (level[0] * level[1]) / 2;
                        if (queryGames.Verbs() >= numberImage)
                        { Imagenes = queryGames.RandomVerbsImage(numberImage); }
                        else { MessageBox.Show("there are not enough verbs for this level"); }
                        return level;
                case 10: { return level = new int[] { 8, 12 }; };
                case 11: { return level = new int[] { 8, 13 }; };
            }
            return level = new int[] { 2, 2 };
        }
        
        /// <summary>
        /// voltearCarta , metodo que se usa para voltear la carta cuando se selecciona
        /// </summary>
        /// <param object="sender"></param>
        /// <param EventArgs="e"></param>
        /// <returns> </returns>
        public  void voltearCarta(object sender, EventArgs e)
        {
      
                if (contadorPar==0) { // si es la carta 1
                   
                    if (contiene('.', imagenVerb)){ // si es imagen se muestra la imagen 
                        eleccionUno.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\image\" + eleccionUno.Text);
                        var pic = new Bitmap(eleccionUno.BackgroundImage, new Size(eleccionUno.Width, eleccionUno.Height));
                        eleccionUno.BackgroundImage = pic;
                    } else {//si es verbo
                        eleccionUno.Font = new Font(eleccionUno.Font.FontFamily, 15, FontStyle.Bold);
                        eleccionUno.ForeColor = Color.Black;
                    }
                }else{
                    Button btn = (Button)sender;
                    if (btn.Text.Contains(".")) {
                        btn.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\image\" + btn.Text);
                        var pic = new Bitmap(btn.BackgroundImage, new Size(btn.Width, btn.Height));
                        btn.BackgroundImage = pic;
                    }
                    else {
                        btn.Font = new Font(btn.Font.FontFamily, 15, FontStyle.Bold);
                    btn.ForeColor = Color.Black;
                    }
                }
                
        }
        
        /// <summary>
        ///  regresaCarta : se ejecuta cuando las dos cartas seleccionadas son diferntes las regresa a su pocision inicial
        /// </summary>
        /// <param name="sender">button o carta a voltear </param>
        /// <param name="e">no lo ocupo </param>
        public  void regresarCarta(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text.Contains("."))
            { btn.BackgroundImage = null; }
            else
            {
                btn.ForeColor = Color.Silver;
                btn = null;
                btn = null;
            }
            if (contiene('.', imagenVerb))
            { eleccionUno.BackgroundImage = null; }
            else
            { //primera.Font = new Font(btn.Font.FontFamily, 1);
                eleccionUno.ForeColor = Color.Silver;
            }
            primeraVerb = "";
            imagenVerb = "";
            actual = "";
           
        }


        /// <summary>
        /// selectCart : metodo para todas las cartas en el panel de juego , recibe la carta y la voltea 
        /// </summary>
        /// <param object="sender">button de tipo carta</param>
        /// <param EventArgs="e"></param>
        public async void selectCart(object sender, EventArgs e)
        {
            
                MemoryGame.driver++;
                if (contadorPar == 0)  { // primera carta 
                    eleccionUno = (Button)sender; // carta uno guardada
                    imagenVerb = eleccionUno.Text; // el nombre de la imagen 
                    if (contiene('.', imagenVerb)) //si  tiene punto, imagen 
                    { primeraVerb = eleccionUno.Text.Substring(0, eleccionUno.Text.LastIndexOf('.')); } // se guarda el nombre para compara el verbo sin su extencion
                    else { primeraVerb = imagenVerb;  } // si no se gurda normal por qu no es una imagen, es un verbo
                    voltearCarta(sender,e); // voltear carta
                    contadorPar++;
                 }

                if (contadorPar == 1 && imagenVerb != ((Button)sender).Text)  // aqui esta el problema por que no se suma el contador 
                {
                    voltearCarta(sender, e); // @meth
                    Button btn = (Button)sender;
                    if (contiene('.', btn.Text)) { actual = btn.Text.Substring(0, btn.Text.LastIndexOf('.')); }
                    else { actual = btn.Text; }
                    if (actual == primeraVerb)
                    {
                        eleccionUno.Enabled = false;
                        btn.Enabled = false;
                        contadorEncontradas++;
                        Pares.Text = contadorEncontradas + "/" + Imagenes.Length;
                        if (contadorEncontradas == Imagenes.Length)
                        {
                            LevelStrart++;
                            MessageBox.Show("WINNER");
                            MemoryGame game2 = new MemoryGame(LevelStrart);
                            this.Hide();
                            game2.Show();
                        }
                        await Task.Delay(1000);
                    }
                    else
                    {
                        await Task.Delay(1000);
                        regresarCarta(btn, e);
                    }
                    intento++;
                    intentos.Text = "" + intento;
                    MemoryGame.contadorPar = 0;
            }
        }

        public bool contiene(char a , string frase)
        {
            foreach (char letra in frase)
            {
                if (letra == a)
                    return true;
            }
            return false;
        }
        private void imagenBoton(Button btn) {
            btn.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\image\" + btn.Text);
            var pic = new Bitmap(btn.BackgroundImage, new Size(btn.Width, btn.Height));
            btn.BackgroundImage = pic;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            EnApp app = new EnApp();
            app.Show();
            this.Hide();
        }

        private void MemoryGame_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(" ancho de la ventana" + this.Width + " \n" + "alto de la venta " + this.Height);
            int ancho = this.Width;
            int alto = this.Height;
            PanelControl.Width = ancho-((ancho*2)/100)-3;
            PanelCartas.Width = PanelControl.Width;
            PanelControl.Height = (alto *10)/100;
            PanelCartas.Height = alto -(PanelControl.Height*2);
            PanelCartas.Margin = new Padding(0,25,0,0);
            PanelControl.Padding = new Padding(5,5,5,25);
            EtiquetaGame.Location = new Point(0 ,0);
            PanelControl.Controls.Add(EtiquetaGame);
            PanelControl.Controls.Add(etiquetaRecord);
            PanelControl.Controls.Add(record);
            PanelControl.Controls.Add(etiquetaLabel);
            PanelControl.Controls.Add(level);
            Home.Left = PanelControl.Width - (Home.Width+(Home.Width*10)/100);
            Home.Top = 3;
            PanelControl.Controls.Add(Home);
            intentos.Text = intento.ToString() ;
            btnPlay_Click(null,EventArgs.Empty);
        }

        private void arreglaDatos()
        {
            datos = new String[(Imagenes.Length*2)];
            int rand;
            for (int k=0; k<Imagenes.Length;k++)
            {
                 rand = rnd.Next(0,2);
                if (rand==1)
                {
                    datos[((Imagenes.Length * 2) - 1) - k] = Imagenes[k];
                    datos[k] = Imagenes[k].Substring(0, Imagenes[k].LastIndexOf('.'));
                }else
                {
                    datos[k] = Imagenes[k].Substring(0, Imagenes[k].LastIndexOf('.'));
                    datos[((Imagenes.Length * 2) - 1) - k] = Imagenes[k];
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (LevelStrart == 10) { level.Text = "***** MASTER LEVEL (" + LevelStrart + ") *****"; } else { level.Text = "" + LevelStrart; }
            if (LevelStrart == 11) { level.Text = "***** GOD LEVEL (" + LevelStrart + ") *****"; }
            if (LevelStrart == 1) { level.Text = "*****  BABY LEVEL (" + LevelStrart + ") *****"; }

           
            int[] filasColumnas = LevelSetUp(LevelStrart);// array{filas,columnas}
            int contadorCartas = 0;
            // filas columnas
            int filas = filasColumnas[0];
            int columnas = filasColumnas[1];
            
            //tamaño del boton carta 
            int tamanio = (PanelCartas.Height / filas) - 10;
            int ancho = PanelCartas.Width;
            PanelCartas.Show();
            numeroCartas = filas * columnas;
            arreglaDatos();
            Pares.Text = contadorEncontradas + "/" + Imagenes.Length;
            int y = 10; ///posicion del primer boton    
            for (int i = 1; i <= filas; i++) 
            {
                int xlocation = ((ancho / columnas) - tamanio)/2;
                for (int j = 1; j <= columnas; j++)
                {
                    if (contadorCartas != (Imagenes.Length * 2))
                    {
                        Button newButton = new Button();
                        {
                            newButton.Font = new Font(newButton.Font.FontFamily, 1);
                            newButton.ForeColor = Color.Silver;
                            newButton.Location = new Point(xlocation, y);
                            newButton.Size = new Size(tamanio, tamanio);
                            newButton.Click += selectCart;
                            newButton.BackColor = Color.Silver;
                            newButton.Name = string.Format("carta" + contadorCartas);
                            newButton.Text = datos[contadorCartas];
                            contadorCartas++;
                            /*if (inicio>=0 && inicio < Imagenes.Length) {
                                // newButton.BackgroundImage = Image.FromFile(System.IO.Directory.GetCurrentDirectory()+@"\image\"+ Imagenes[inicio]);
                                //var pic = new Bitmap(newButton.BackgroundImage, new Size(newButton.Width, newButton.Height));
                                // newButton.BackgroundImage = pic;
                                newButton.Text = Imagenes[inicio].Substring(0, Imagenes[inicio].LastIndexOf('.'));

                            } else {
                                newButton.Name = string.Format("no" + inicio);
                                newButton.BackColor = Color.Silver;
                            }

                            inicio++;*/
                            PanelCartas.Controls.Add(newButton);
                        }
                        xlocation += (PanelCartas.Width / columnas);
                    }
                }
                y = y + tamanio + 4;
            }
        }
    }
}
