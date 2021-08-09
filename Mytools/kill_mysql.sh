ps -ef | grep mysql | awk '/--defaults-file/{print $2}' > ./mysql.txt
num1=`sed -n '$=' mysql.txt`

for i in seq $(cat mysql.txt)
do 
mynum=`cat mysql.txt | awk 'NR==1{print$0}'`
kill -9 $mynum
sed -i 1d mysql.txt
done

sudo rm -rf mysql.txt
