using System.ComponentModel;
using System.Dynamic;

class Activity{
private string _type;
private int _length;
private string _description;
public Activity(){

}
public Activity(string type, int length){
    _type = type;
    _length = length;
}
public void SetDiscription(string description)
{
    _description = description;
}
private void Wait(){

} 
private void Run(){

}
private void End(){

}

}