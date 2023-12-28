void Main()
{
	//Predicate => delegate for method with boolean return value and single parameter
	//public delegate bool Predicate(xxxx);
	Predicate<int> myPredicate = MyMethod; 
}
bool MyMethod(int x) {
	return true;
}
bool Bandingkan(int price) {
	return price > 10;
}