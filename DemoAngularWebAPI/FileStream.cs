string sourcefile = @"D:\TEST.xlsx";

            string Destinationfile = @"D:\1";

            using (System.IO.FileStream filestream = new System.IO.FileStream(sourcefile, FileMode.Open))
            {
                var DestfileStream = new System.IO.FileStream(Destinationfile, FileMode.Create, FileAccess.Write);

                filestream.CopyTo(DestfileStream);
                filestream.Close();
                DestfileStream.Close();
                // CopyStream(filestream, Destinationfile);
            }


            sourcefile = @"D:\1";
            Destinationfile = @"D:\TEST_ABTEST.xlsx";

            using (System.IO.FileStream filestream = new System.IO.FileStream(sourcefile, FileMode.Open))
            {
                var fileStream = new System.IO.FileStream(Destinationfile, FileMode.Create, FileAccess.Write);

                filestream.CopyTo(fileStream);
                filestream.Close();
                // CopyStream(filestream, Destinationfile);
            }
