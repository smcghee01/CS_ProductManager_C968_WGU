# Software_1_Forms_App

Scenario:
You are working for a small manufacturing organization that has outgrown its current inventory system. They have been using a spreadsheet program to manually enter inventory additions, deletions, and other data from a paper-based system but would now like you to develop a more sophisticated inventory program.

They have provided you with a mock-up of the user interface to use in the design and development of the system (see the attached “GUI Mock-Up”) and a class diagram to assist you in your work (see the attached “UML Class Diagram”). The organization also has specific business requirements that must be included as part of the application. A system analyst from your company created the solution statements outlined in the requirements section based on the manufacturing organization’s business requirements. You will use these solution statements to develop your application.

Requirements:
I. User Interface

Create a C# application with a graphical user interface (GUI) based on the attached “GUI Mock-Up.” Write code to display each of the following forms in the GUI:

A.  A main form, showing the following controls:
      1) buttons for “Add,” “Modify,” “Delete,” “Search” for parts and products, and “Exit”
      2) lists for parts and products
      3) text boxes for searching for parts and products
      4) title labels for parts, products, and the application title

B.  An add part form, showing the following controls:
      1) radio buttons for “In-House” and “Outsourced” parts
      2) buttons for “Save” and “Cancel”
      3) text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID
      4) labels for ID, name, inventory level, price/cost, max and min values, the application title, and company name or machine ID

C.  A modify part form, with fields that populate with data from an existing Part, showing the following controls:
      1) radio buttons for “In-House” and “Outsourced” parts
      2) buttons for “Save” and “Cancel”
      3) text boxes for ID, name, inventory level, price, max and min values, and company name or machine ID
      4) labels for ID, name, inventory level, price, max and min values, the application title, and company name or machine ID
      
D .  An add product form, showing the following controls:
      1) buttons for “Save,” “Cancel,” “Add” part, and “Delete” part
      2) text boxes for ID, name, inventory level, price, and max and min values
      3) labels for ID, name, inventory level, price, max and min values, and the application
      4) a grid view for all parts
      5) a grid view for parts associated with the product
      6) a “Search” button and a text field with an associated list for displaying the results of the search

E.  A modify product form, with fields that populate with data from an existing product, showing the following controls:
      1) buttons for “Save,” “Cancel,” “Add” part, and “Delete” part
      2) text boxes for ID, name, inventory level, price, and max and min values
      3) labels for ID, name, inventory level, price, max and min values, and the application “all candidate parts”
      4) a grid view for parts associated with the product
      5) a “Search” button and a text box with associated list for displaying the results of the search

II. Application

Now that you’ve created the GUI, write code to create the class structure provided in the attached “UML (unified modeling language) Class Diagram.” Enable each of the following capabilities in the application:

F.  Using the attached “UML Class Diagram,” create appropriate classes and instance variables with the following criteria:
      1) five classes with the all associated properties
      2) variables are accessible/modifiable through properties

G.  Add the following functionalities to the main form, using the methods provided in the attached “UML Class Diagram”:
      1) redirect the user to the “Add Part,” “Modify Part,” “Add Product,” or “Modify Product” forms
      2) delete a selected part or product from the grid view
      3) search for a part or product and display matching results
      4) exit the main form

H.  Add the following functionalities to the part forms, using the methods provided in the attached “UML Class Diagram”:

1. “Add Part” form
    a) select “In-House” or “Outsourced”
    b) enter name, inventory level, price, max and min values, and company name or machine ID
    c) save the data and then redirect to the main form
    d) cancel or exit out of this form and go back to the main form

2. “Modify Part” form
    a) select “In-House” or “Outsourced”
    b) modify or change data values
    c) save modifications to the data and then redirect to the main form
    d) cancel or exit out of this form and go back to the main form

I.  Add the following functionalities to the product forms, using the methods provided in the attached “UML Class Diagram”:

1. “Add Product” form
    a) enter name, inventory level, price, and max and min values
    b) save the data and then redirect to the main form
    c) associate one or more parts with a product
    d) remove or disassociate a part from a product
    e) cancel or exit out of this form and go back to the main form

2.   “Modify Product” form
    a) modify or change data values
    b) save modifications to the data and then redirect to the main form
    c) associate one or more parts with a product
    d) remove or disassociate a part from a product
    e) cancel or exit out of this form and go back to the main form

J.  Write code to address the following conditions with exception handling code:
    a) Detect non-numeric values in textboxes that expect numeric values
    b) Min should be less than Max; and Inv should be between those two values
    c) Prevent the user from deleting a product that has a Part associated with it
    d) Confirm “Delete” actions
