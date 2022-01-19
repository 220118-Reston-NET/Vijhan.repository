repeat="true"
while [ "$repeat" == true ]
do

echo "Welcome to Panda Express"
echo "Type 1 for orange chicken and fried rice"
echo "Type 2 for teriyaki chicken and fried rice"
echo "Type 0 for nothing im broke"
read num
if [ "$num" == 1 ]
then
echo "Here is your orange chicken and fried rice"
echo "Enjoy!"
elif [ "$num" == 2 ]
then
echo "Here is your teriyaki chicken and fried rice"
echo "Enjoy!"
elif [ "$num" == 0 ]
then
echo "Goodbye"
repeat="false"
else
echo "Invalid number"
echo " "
fi

done
