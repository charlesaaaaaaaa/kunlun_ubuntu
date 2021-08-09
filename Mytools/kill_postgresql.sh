ps -ef | grep postgres | awk '/postgres -D /{print $2}' > ./postgresql.txt
num1=`sed -n '$=' postgresql.txt`

for i in seq $(cat postgresql.txt)
do 
mynum=`cat postgresql.txt | awk 'NR==1{print$0}'`
kill -9 $mynum
sed -i 1d postgresql.txt
done

sudo rm -rf postgresql.txt
