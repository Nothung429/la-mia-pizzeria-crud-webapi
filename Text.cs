//PARTE 1

//Completiamo le pagine di gestione delle nostre pizze!
//Abbiamo la pagina con la lista di tutte le pizze, quella con i dettagli della singola pizza, quella per crearla...cosa manca?

//Dobbiamo realizzare :
//    pagina di modifica di una pizza
//    cancellazione di una pizza cliccando un pulsante presente nella grafica di ogni singolo prodotto mostrato nella lista in homepage


//PARTE 2

//Oggi sviluppiamo un’importante funzionalità : aggiungiamo una categoria alle nostre pizze (“Pizze classiche”, “Pizze bianche”, “Pizze vegetariane”, “Pizze di mare”, ...).

//Dobbiamo quindi predisporre tutto il codice necessario per poter collegare una categoria a una pizza (in una relazione 1 a molti, cioè una pizza può avere una sola categoria, e una categoria può essere collegata a più pizze). Tramite migration dobbiamo creare la tabella per le categorie. Popoliamola a mano con i valori elencati precedentemente.

//Aggiungiamo poi l’informazione della categoria nelle varie pagine :
//    nei dettagli di una singola pizza (nell’admin) mostrare la sua categoria
//    quando si crea/modifica una pizza si deve poter selezionare anche la sua categoria


//PARTE 3

//Oggi sviluppiamo un’altra importante funzionalità : aggiungiamo gli ingredienti alle nostre pizze.
//Una pizza può avere più ingredienti, e un ingrediente può essere presente in più pizze.


//PARTE 4

//Proteggiamo le nostre pagine di gestione delle pizze!
//Aggiungiamo tutto il necessario per la login e la registrazione.
//Ricordiamoci poi di bloccare l’accesso al nostro controller delle Pizze con [Authorize] e creiamo una HomePage dove verrà rimandato l’utente dopo il logout.


//PARTE 5

//Attenzione: dobbiamo fare la procedura di reset del git usata anche per il precedente progetto!
//Fatto questo, andiamo avanti col nostro progetto!
//Abbiamo studiato cosa sono le WebApi...è il momento di mettere in pratica quello che abbiamo imparato.
//Dobbiamo quindi creare un controller Controllers/Api/PizzasController che implementerà le nostre webapi. Deve avere un metodo Get() che restituisca la lista delle pizze che offre la nostra pizzeria.
//Dobbiamo poi modificare la nostra homepage Controller/HomeController, che richiamerà utilizzando axios il metodo Get() appena creato e che mostrerà i dati ottenuti tramite codice javascript.


//PARTE 6

//La nostra pizzeria è quasi conclusa...ma...come fanno i nostri clienti a trovare una pizza se ne abbiamo tante nel nostro menu? Dobbiamo dargli la possibilità di ricercarle con un filtro.
//Modifichiamo quindi la pagina index, aggiungendo un text input di ricerca. Ogni volta che viene scritto qualcosa, il sistema deve interrogare le nostre WebApi chiedendo indietro le pizze che contengono nel titolo quello che ha chiesto l’utente, e mostriamo in pagina i risultati filtrati.
//Al click della card di una pizza, dobbiamo essere portati a una pagina di dettaglio. I dati da mostrare di questa pagina devono essere richiesti alle nostra webapi tramite l’id della pizza e mostrati in pagina usando il javascript.


//PARTE 7

//Il rapporto con i clienti è importante…quindi perchè non permettergli di inviarci dei messaggi?
//Creiamo il nostro model Message e relativa migration per gestire i dati. Implementiamo un nuovo controller Api/MessagesController con il metodo Post.
//Andiamo nella homepage e aggiungiamo l’html per il form dei messaggi e il codice javascript per eseguire il post tramite axios.


//PARTE 8

//Ciao ragazzi, sulla base di quello che abbiamo visto oggi, procediamo a modificare il programma della pizzeria aggiungendo queste specifiche:
//    Inserire Put e Delete delle nostre pizze nelle action del nostro ApiController e quindi sul frontend per gestire la cancellazione e l’aggiornamento.
//    Inseriamo i repository di tutte le entità per spostare la logica di accesso al db e alleggerire i nostri controller.
//    Sfruttiamo l’injection per caricare il nostro DbContext direttamente all’avvio del sistema.

//Bonus: Se vi rimane tempo e volete sperimentare quanto visto in livecoding sull’injection, potete provare a costruire (di almeno una entita) un InMemoryRepository che implementi la persistenza dei dati sui Generics.

//builder.Services.AddScoped<BlogContext>();
