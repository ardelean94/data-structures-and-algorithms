/******In order to EXECUTE - Add the following lines in Program.cs > Main method:******/

Node head=null;
int T=Int32.Parse(Console.ReadLine());
while(T-->0){
    int data=Int32.Parse(Console.ReadLine());
    head=insert(head,data);
}
display(head);

