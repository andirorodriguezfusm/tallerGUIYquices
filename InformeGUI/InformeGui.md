#INFORME DE GUI  


## GUI SCRIPTING ##

##GUI BUTTON:

VISION EL CONJUNTO EXPLIKA SOBRE EL BUTTON ES LO MISMO  SOBRE HTML TABLAS   QUE PUEDE RESPRENTA COMO IMAGEN AL BUTTON  Y TAMBIEN PERSONALIZAR COMO GUIStyles y GUISkins  Y MOSTRAREMOS LA EXPLICACION  DEL CODIGO:

	function OnGUI () {

	//GUI.BUTTON CUANDO SE CREA EL BUTTON  Y EL REC SON LA POSICION LA CORDENADAS QUE SON IZQUIERDA,DERECHA,ACHO,ALTURA.

	if (GUI.Button (Rect (10,10,150,100), "I am a button")) {

	//ESTO PRINT REPRENTA CUANDO LE DAMOS CLICK  BUTTON  LE MUESTRA EL MESANJE QUE IMPRIME  		
	print ("You clicked the button!");
	
	}
	}


##  GUI BOX:

ES UN LISTA MENU  QUE VA REPESENTAR  COMO UN BUTTON,TEXTO  Y IMAGEN O ICONOS MOSTRAREMOS EL EJEMPLO DEL CODIGO:


	// JavaScript
	function OnGUI () {
	
	// Hacer un cuadro de LA LISTA DE MENU
	
	GUI.Box (Rect (10,10,100,90), "Menú Loader");

	/ / AQUI VA REPRESENTAR BUTTON  DENTRO EL BOX
	if (GUI.Button (Rect (20,40,80,20), el "Nivel 1")) {
		Application.LoadLevel (1);
	}

	/ / Hacer que el segundo botón.
	if (GUI.Button (Rect (20,70,80,20), "Nivel 2")) {
		Application.LoadLevel (2);
	}}
 
HAY OTRA FORMA BOX  CUANDO UTILIZA EL CODIGO screen.width y Screen.Height  ESO SON LAS PROPIEDADES QUE SIRVE  TAMAÑO BOX QUE SON  ALTURA,ANCHO.

	/ / JavaScript
	function OnGUI () {
	
	//ESTO SON LA POSICION DE LA CORRDENADAS DE LA POSICION
	
	GUI.Box (Rect (0,0,100,50), "Top-izquierda");
	
	//ESTO REPRESENTA EL ANCHO BOX Y INDICA HACIA LA DERECHA
 
	GUI.Box (Rect (screen.width - 100,0,100,50), "Arriba a la derecha");

	//ESTO REPRESENTA ALTURA 
	GUI.Box (Rect (0, Screen.Height - 50,100,50), "izquierda-abajo");

	//ESTO REPRESENTA ANCHO Y EL ALTURA

	GUI.Box (Rect (screen.width - 100, Screen.Height - 50,100,50), "Bottom-right");
	}

##GUI LABEL:

SIVER PARA ESCRIBIR COMO UN TEXTO  Y COMO UN TITULO Y NO SE PUEDE HACER CLICK  O NO SE MOVIO  LE MOSTRAREMOS EL CODIGO:

	/ / JavaScript

	function OnGUI () {

	//hay representa el label con cordenada y nombre del titulo.
	
	GUI.Label (Rect (25, 25, 100, 30), "Etiqueta");
	}


##GUI RAPEATBUTTON:
SIRVE CUANDO SI LA CONDICION DEL CODIGO LE DAMOS  CLIK BUTTON  RESPONDERA EL FOTOGRAMA  Y PERMITE CREAR  FUNCIONALIDAD CLICK,AND,HOLD.

	function OnGUI () {
	
	IF (GUI.RepeatButton (Rect (25, 25, 100, 30), "RepeatButton")) {
		
	/ / Este código se ejecuta cada fotograma que el RepeatButton queda hecho clic
	
	}
	}

##GUI TEXFIELD:

ES UN CONTROL DE CAMPO  DE UN SOLO LINEA INTERACTIVO,EDITABLE  QUE CONTIENE  UNA CADENA DE TEXTO.

	 //JavaScript

	//HAY SE DECLARA UN STRING  PARA PODE ESCRIBIR CAMPO DE LINEA
	textFieldString var = "campo de texto";

	function OnGUI () {

	//LLAMA LA VARIABLE CREADO  Y DESPUES SE CREAR TEXFIELD COMO LA POSICION DE LA CORDENADA  LLAMAVA LA VARIABLE PARA EMPEZAR ESCRIBIR  CAMPO DE LINEA

	textFieldString = GUI.TextField (Rect (25, 25, 100, 30), textFieldString);
	}


##GUI TEXTAREA:


ES EL CONTROL  ES UN AREA MULTI-LINEA INTERACTIVO ,EDITABLE  QUE CONTIENE UNA CADENA TEXTO

	// JavaScript

	HAY SE DECLARA UN STRING  PARA PODE ESCRIBIR CAMPO DE TEXTO
	textAreaString var = "área de texto";

	function OnGUI () {

	//LLAMA LA VARIABLE CREADO  Y DESPUES SE CREAR TEXTAREA COMO LA POSICION DE LA CORDENADA  LLAMAVA LA VARIABLE PARA EMPEZAR ESCRIBIR  CAMPO DE TEXTO

	textAreaString = GUI.TextArea (Rect (25, 25, 100, 30), textAreaString);

	}


##GUI PALANCA:

LA PALANCA ES COMO UN SELECCION  PERSISTE COMO UN ESTADO ENCEDIDO  O APAGADO

	// JavaScript

	HAY SE DECLARA UN BOOLEANO QUE VA RETORNA 

	var toggleBool = true;


	function OnGUI () {
	
	HAY  SE CREA VARIABLE  BOOLEANO QUE VA RETORNA CUANDO LE DA CLICK A LA SELECCION  
	toggleBool = GUI.Toggle (Rect (25, 25, 100, 30), toggleBool, "Toggle");
	}


##GUI TOOLBAR:
 ES UN BARRA HERRAMIENTAS QUE HILIERA LOS BOTONES  QUE  REALIZAR NUMEROS DE ENTEROS QUE REPRESAENTA EN EL CODIGO:


	/ / JavaScript

	HAY SE CREA UN VARIABLE EN UN ENTERO

	var toolbarInt = 0;

	HAY SE DECLARA  VARIABLE STRING 
	toolbarStrings var: String [] = ["Toolbar1", "Toolbar2", "Toolbar3"];

	function OnGUI () {
	HAY SE CREAR UN TOOLBAR COMO ENTERO  HACE UN LLAMDA INT Y STRING 
	toolbarInt = GUI.Toolbar (Rect (25, 25, 250, 30), toolbarInt, 

	toolbarStrings);
	}

##GUI SELECTIONGIRD:

ES EL CONTROL FILA Y COLUMNAS TOOLBAR DETERMINAR NUMEROS DE COLUMNAS Y FILAS DE LA CUADRICULA EN UN SOLO BOTON A LA VEZ ACTIVA.

	/ / JavaScript
	SE CREA UNA VARIABLE  EN ENTERO 
	selectionGridInt var: int = 0;
	SE CREA UN VARIABLE  ES UN STRING LAS LISTA QUE DETERMINA ES CODIGO
	selectionStrings var: String [] = ["Cuadrícula 1", "Grid 2", "rejilla 3", "4 de 	cuadrícula"];

	function OnGUI () {
	HAY SE CREA SELECCION GIRD COMO UN BOTOBY DETERMINA LA LLAMADA SELECCION 
	selectionGridInt = GUI.SelectionGrid (Rect (25, 25, 100, 30), selectionGridInt, selectionStrings, 2);

	}


##GUI HORIZONTAL SLIDER:

 ES UN CONTROL MANDO TIPICO HORIZONTAL DESLIZANTE QUE PUEDE ARRASTAR PARA CAMBIAR EL PREDETERMINADO Y LOS VALOS MAXIMOS

	// JavaScript
	SE CREA UN VARIABLE FLOTANTE
	hSliderValue var: float = 0,0;

	function OnGUI () {
	HAY SE CREA HORIZONTALSLIDER Y LLLAMA  LA VARIABLE  PARA DAR LOS VALORES MAXIMOS
	hSliderValue = GUI.HorizontalSlider (Rect (25, 25, 100, 30), hSliderValue, 0,0, 10,0);
	}

##GUI VERTICAL SLIDER:
ES UN CONTROL MANDO TIPICO HORIZONTAL DESLIZANTE QUE PUEDE ARRASTAR PARA CAMBIAR EL PREDETERMINADO Y LOS VALOS MAXIMOS.

	// JavaScript
	SE CREA UN VARIABLE FLOTANTE
	vSliderValue var: float = 0,0;

	function OnGUI () {
	HAY SE CREA VERTICALSLIDER Y LLLAMA  LA VARIABLE  PARA DAR LOS VALORES MAXIMOS
	vSliderValue = GUI.VerticalSlider (Rect (25, 25, 100, 30), vSliderValue, 10,0, 0,0);
	}


##GUI HORIZONTALSCROLLBAR:

ES UN CONTROL DE DESLIZADOR   QUE VISUALMENTE  SON LOS ELEMENTOS  NAVEGADORES  WEB POR ESO UTILZA SCROLLVIEW CONTROL.

	/ / JavaScript
	SE CREA UN VARIABLE FLOTANTE
	hScrollbarValue var: float;

	function OnGUI () {
	LLAMA UN FLOTANTE  Y SE CREA HORIZONTALSCROLLBAR  POSICION  Y LLAMA  LA VARIABLE CREA EN FLOTANTE Y EL TAMAÑO  HORIZONTALSCROLLBAR
	hScrollbarValue = GUI.HorizontalScrollbar (Rect (25, 25, 100, 30), hScrollbarValue, 1,0, 0,0, 10,0);
	}


##GUI VERTICALLSCROLLBAR:

ES UN CONTROL DE DESLIZADOR   QUE VISUALMENTE  SON LOS ELEMENTOS  NAVEGADORES  WEB POR ESO UTILZA SCROLLVIEW CONTROL.

/ / JavaScript
	SE CREA UN VARIABLE FLOTANTE
	hScrollbarValue var: float;

	function OnGUI () {
	LLAMA UN FLOTANTE  Y SE CREA VERTICALSCROLLBAR  POSICION  Y LLAMA  LA VARIABLE CREA EN FLOTANTE Y EL TAMAÑO  VERTICALCROLLBAR
	hScrollbarValue = GUI.VerticalScrollbar (Rect (25, 25, 100, 30), hScrollbarValue, 1,0, 0,0, 10,0);
	}

##GUI SCROLLVIEW:

SON CONTROLES QUE MUESTRAN  UNA AREA VISIBLE  DE UN CONJUNTO MUCHO MAS  AMPLIO DE CONTROLES.

	/ / JavaScript
	scrollViewVector var: Vector2 = Vector2.zero;
	innerText var: String = "Estoy dentro de la ScrollView";

	function OnGUI () {
	/ / Comienza la ScrollView 
	scrollViewVector = GUI.BeginScrollView (Rect (25, 25, 100, 100), scrollViewVector, Rect (0, 0, 400, 400));

	/ / Poner algo en el interior del ScrollView
	innerText = GUI.TextArea (Rect (0, 0, 400, 400), innerText);

	/ / Fin de la ScrollView
	GUI.EndScrollView ();
	}

##GUI VENTANA:

SON CONTENEDORES CAPACES DE ARRASTRAR CONTROLES CUANDO LE D ACLICK IDENTIFICA  DEL NUMERO Y CONTENIDO  DENTRO DE UN FUNCION SEPARADA QUE SE LLAMA UN VENTANA EN FOCO.

 	/ / JavaScript
	 HAY SE DESCALAR LA VARIABLE CON LA POSICION DE LA COORDENADAS
	windowRect var: = Rect Rect (20, 20, 120, 50);

	function OnGUI () {
		HAY MUESTRA EL WINDOWS CREADO CON LA LETRA DE LAPOSCION CREADAS EN VAR  YA TOMADO COMO UN TEXTO
		windowRect = GUI.Window (0, windowRect, WindowFunction, "My Window");
	}

	function WindowFunction (windowID: int) {
	/ / Dibujar cualquier control dentro de la ventana aquí
	}

##GUI LAYOUT FIJO Y DISEÑO AUTOMATICO:

LAYOUT ES UN INTERFAZ GRAFICA  NO UTILZA REC LA YOUT SIRVE PARA TENER AUTOMATICO LOS BOTONES NO SE SABE CUANTOS SE DIBUJARA DEPEDIENDO EL DISEÑO DE SU JUEGO.

	/ / JavaScript
	function OnGUI () {
	/ / Layout fijo CREA UN BOTTON
	GUI.Button (Rect (25,25,100,30), "Yo soy un botón de diseño fijo");

	/ / SE CREA UN BOTTON DEL DISEÑO AUTOMATICO
	GUILayout.Button ("Yo soy un botón Diseño automático");
}

##GUI LAYOUT FIJO Y GRUPOS:

PERMITEN DEFINIR  LA AREAS DE LA PANTALLA VARIOS CONTROLES SE QUR COLOCARAN SOBRE LA BASE DE3 LA ESQUINIA  SUPERIOR IZQUIERDA DELGRUPO EN LUGAR DE LA ESQUINA SUPERIOR IZQUIERDA DE LA PANTALLA.


	// JavaScript
	function OnGUI () {
	/ / Se crea un grupo en el centro de la pantalla
	GUI.BeginGroup (Rect (screen.width / 2 - 50, Screen.Height / 2 - 50, 100, 100));
	/ / Todos los rectángulos están ajustados para el grupo. (0,0) es la esquina superior de pérdidas del grupo.

	/ / Vamos a hacer una BOX Y BOTTON para que pueda ver que el grupo está en la pantalla.
	GUI.Box (Rect (0,0,100,100), "Grupo está aquí");
	GUI.Button (Rect (10,40,80,30), "Haga clic en mí");

	/ / TERMINA EL GRUPO 
	GUI.EndGroup ();
}

HAY OTRA FORMA CON IMAGEN

	/ / JavaScript
	ES SE LLAMA UN VARIABLE Y LLAMA LA CARPETA LA RUTA IMGAEN 
	bgimage var: Texture2D; / Imagen / fondo que es 256 x 32
	TAMAÑO DE PIXRLES DE IMAGEN
	fgImage var: Texture2D; / / Imagen en primer plano que es 256 x 32
	var playerEnergy = 1,0; / / Un flotador entre 0.0 y 1.0

	function OnGUI () {
	/ / Crear un Grupo de contenedores tanto imágenes
	/ / Ajustar las 2 primeras coordenadas para colocarla en otro lugar de la pantalla
	GUI.BeginGroup (Rect (0,0,256,32));

	/ / Dibujar la imagen de fondo
	GUI.Box (Rect (0,0,256,32), bgimage);

	/ / Se crea un segundo grupo que se recorta
	/ / Queremos recortar la imagen y no reduce la escala, que es por eso que necesitamos el segundo grupo
	GUI.BeginGroup (Rect (0,0, playerEnergy * 256, 32));

	/ / Dibuja la imagen en primer plano
	GUI.Box (Rect (0,0,256,32), fgImage);

	/ / Fin de ambos Grupos
	GUI.EndGroup ();
	GUI.EndGroup ();
	}

##GUI LAYOUT FIJO Y GRUPOS:

UTILZAN EL MODO DE DISEÑO AUTOMATICO SON SIMILARES A LOS FIJOS GRUPOS DE DISEÑO EN CUANTO A FUNCIONALIDAD QUE YA DEFINE LIMITADO LA PANTALLA PARA CONTENER CONTROL GUILAYOUT. 

 	/ JavaScript
	function OnGUI () {
	SE CREA UN LAYOUT CON EL BUTTON NO ESTA EN LA AREA
	GUILayout.Button ("Yo no estoy dentro de un Área");
	 SE CREA UN AREA  CON EL POSCION DE LA  PANTALLA 
	GUILayout.BeginArea (Rect (screen.width / 2, Screen.Height / 2, 300, 300));
	SE CREA UN LAYOUT CON EL BUTTON DENTRO EL AREA
	GUILayout.Button ("Estoy completamente dentro de un Area");
	TERMINA EL POROCESO DE LAYOUT
	GUILayout.EndArea ();
	}

## DISEÑO AUTOMATICO Y GRUPO HORIZONTAL,VERTICAL:

SE COLOCAN CONTROLES Y SE ORGANIZAN SI ESTA UTILIZANDO EL MODO DE DISEÑO AUTOMATICO USTED TIENE LA OPCION  DE HORIZONTAL Y VERTICAL DE GRUPOS.

	/ / JavaScript
	var sliderValue = 1,0;
	var maxSliderValue = 10,0;

	functión OnGUI ()
	{
	/ / Envolver todo en el Área GUI designado
	GUILayout.BeginArea (Rect (0,0,200,60));

	/ / Comienza el Grupo Horizontal singular
	GUILayout.BeginHorizontal ();

	/ / Colocar un botón normalmente
	if (GUILayout.RepeatButton ("Aumentar max \ nSlider Valor"))
	{
		maxSliderValue + = 3,0 * Time.deltaTime;
	}

	/ / Organizar dos controles más verticalmente al lado del botón
	GUILayout.BeginVertical ();
	GUILayout.Box ("deslizante Valor:" + Mathf.Round (sliderValue));
	SE CREA COMO UN SCROOLBAR
	sliderValue = GUILayout.HorizontalSlider (sliderValue, 0.0, maxSliderValue);

	/ / termina lo prOcesos  Grupos y de área
	GUILayout.EndVertical ();
	GUILayout.EndHorizontal ();
	GUILayout.EndArea ();
	}

##GUI LAYOUTOPTIONS:


SON PARAMETROS DE DISEÑOS AUTOMATICO  SON LOS PARAMETROS FINALES DEL CONTROL GUI LAYOUT.

	// JavaScript
	function OnGUI () {
	SE CREA ELL AREA CON ANCHO Y ALTURA
	GUILayout.BeginArea (Rect (100, 50, screen.width-200, Screen.Height-100));
	CREA UN BOTON DISEÑADO AUTOMATICO CON ALTURA Y ANCHO
	GUILayout.Button ("Soy un botón Diseño automático normal");
	SE CREA MAXIMO ANCHO  O QUEDA ANULADO 
	GUILayout.Button ("Mi anchura se ha anulado", GUILayout.Width (95));
	TERMINA  EL PROCESO DE LA AREA
	GUILayout.EndArea ();
	}






## Esposible crear interfaces diferente standar de clases en unity

Puede ser posible utilizando un paradigma de programacion llamado AOP  (Aspect orientated Programming",  permite añadir modularidad y extender funciones de un prgrama.

Podria usarse este paradigma para añadir nuevas funciones a Unity que permitan diseñar interfaces usando otros programas como NeatBeans (Crea y diseña  interfaces de forma visual) y asi ir observando el el resultado que se quiere obtener al mismo tiempo.


 ##EVENTOS SOPORTADOS POR UNITY 3D
Los eventos correspondientes a unityGUI son aquellos que correspoden a los diferentes entradas que pueda hacer el usuario (controlador) ejemplo de esto seria: Precionado de botones, acciones con el mouse, etc. a continuación se describiran las diferentes variables que se pueden utilizar y una pequeña descripcion de estas.

VARIABLES ESTÁTICAS

current: Este señala el evento que está siendo procesado en el momento

VARIABLES

Alt: comprueba si la tecla alt del teclado en windows o la tecla option del teclado de mac OS esta siendo presionado.

Button: Comprueba cual boton del mouse o raton está siendo presionado

capsLock: verifica si la tecla capsLock (mayuscula) está activa

character: Si una letra ha sido presionada y cual.

ClickCount: Es un contador de click's dados.

Command: Verifica si la tecla windows/command está siendo presionada

CommandEvent: comandos como copiar, pegar, seleccionar todo, los reconoce y los muestra si envia por debug

control: Comprueba si la tecla Ctrl del teclado está siendo presionada

Delta: Compara la posicion del puntero del mouse con la anterior capturada

FunctionKey: Comprueba si la tecla fn del teclado está siedo presionada.

iskey: verificia si el evento es por teclado

isMouse: verifica si el evento viene por el mouse (raton)

Keycode: devuelve el identificador de la tecla presionada, utiluzado comunmente con las teclas de funcion y de cursor del teclado

modifiers: Comprueba cual(es) tecla modificadora está siendo presionada(s) (shift, ctrl, alt, command, numeric, capslock, functionkey)

mousePosition: devuelve la posicion del cursor del mouse en pantalla

numeric: solo verifica si la tecla presionada se encuentra en el panel numerico del teclado

shift: Comprueba si la tecla shift está siendo presionada.

type: Captura el tipo de evento en proceso.

Functions (funciones)
use: se utiliza para usar un evento especifico

Static Functions (Funciones Estaticas)
KeyboardEvent: Para crear nuevos eventos de teclado.
