echo "Welcome to shell script Diner!"
echo "What do you want to eat for lunch?"
echo "enter 1 if  you want pizza"
echo "enter 2 if you want hamburger"
echo "enter 3 if you want candy"
#echo "quit"
read ans

#menu option 1

if [ "$ans" == "1" ]
then 
echo "Enjoy your pizza"
elif [ "$ans" -ge "3" ]
then
echo "Sorry we don't sell that right now!"
fi

#menu option 2
if [ "$ans" == "2" ]
then
echo "Enjoy your hamburger"
elif [ "$ans" -ge "3" ]
then
echo "Sorry we don't sell that right now!"

fi


#Menu option 3
if [ "$ans" == "3" ]
then
echo "Enjoy your Candy"
elif [ "$ans" -ge "3" ]
then
echo "Sorry we don't sell that right now!"

fi

#Menu option 4
#if [ "$ans"== "quit" ]
#then echo "Have a good day!"
#elif [ "$ans" != "quit" ]
#then
#echo "Sorry please choose an input from the ones listed"

#fi

#While  loop
#while [ "$ans " -le "3" ]
#do 
#echo "enjoy your lunch!"
#done
