/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListDNADBResponseUnmarshaller
    {
        public static ListDNADBResponse Unmarshall(UnmarshallerContext context)
        {
			ListDNADBResponse listDNADBResponse = new ListDNADBResponse();

			listDNADBResponse.HttpResponse = context.HttpResponse;
			listDNADBResponse.RequestId = context.StringValue("ListDNADB.RequestId");

			List<ListDNADBResponse.ListDNADB_DNADB> listDNADBResponse_dNADBList = new List<ListDNADBResponse.ListDNADB_DNADB>();
			for (int i = 0; i < context.Length("ListDNADB.DNADBList.Length"); i++) {
				ListDNADBResponse.ListDNADB_DNADB dNADB = new ListDNADBResponse.ListDNADB_DNADB();
				dNADB.DBId = context.StringValue("ListDNADB.DNADBList["+ i +"].DBId");
				dNADB.Status = context.StringValue("ListDNADB.DNADBList["+ i +"].Status");
				dNADB.DBDescription = context.StringValue("ListDNADB.DNADBList["+ i +"].DBDescription");
				dNADB.DBType = context.StringValue("ListDNADB.DNADBList["+ i +"].DBType");
				dNADB.DBName = context.StringValue("ListDNADB.DNADBList["+ i +"].DBName");
				dNADB.DBRegion = context.StringValue("ListDNADB.DNADBList["+ i +"].DBRegion");

				listDNADBResponse_dNADBList.Add(dNADB);
			}
			listDNADBResponse.DNADBList = listDNADBResponse_dNADBList;
        
			return listDNADBResponse;
        }
    }
}
