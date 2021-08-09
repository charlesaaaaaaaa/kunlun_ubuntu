./runSQL.sh myprops.pg sqlTableDrops
sleep 3
./runSQL.sh myprops.pg sqlTableCreates
sleep 3
./runSQL.sh myprops.pg sqlIndexCreates
sleep 3
./runLoader.sh myprops.pg numWarehouses 1 fileLocation /tmp/csv/
sleep 10
./runSQL.sh myprops.pg sqlTableCopies
