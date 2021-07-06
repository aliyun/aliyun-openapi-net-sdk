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
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ListDataCorrectPreCheckDBResponseUnmarshaller
    {
        public static ListDataCorrectPreCheckDBResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataCorrectPreCheckDBResponse listDataCorrectPreCheckDBResponse = new ListDataCorrectPreCheckDBResponse();

			listDataCorrectPreCheckDBResponse.HttpResponse = _ctx.HttpResponse;
			listDataCorrectPreCheckDBResponse.RequestId = _ctx.StringValue("ListDataCorrectPreCheckDB.RequestId");
			listDataCorrectPreCheckDBResponse.Success = _ctx.BooleanValue("ListDataCorrectPreCheckDB.Success");
			listDataCorrectPreCheckDBResponse.ErrorMessage = _ctx.StringValue("ListDataCorrectPreCheckDB.ErrorMessage");
			listDataCorrectPreCheckDBResponse.ErrorCode = _ctx.StringValue("ListDataCorrectPreCheckDB.ErrorCode");

			List<ListDataCorrectPreCheckDBResponse.ListDataCorrectPreCheckDB_PreCheckDB> listDataCorrectPreCheckDBResponse_preCheckDBList = new List<ListDataCorrectPreCheckDBResponse.ListDataCorrectPreCheckDB_PreCheckDB>();
			for (int i = 0; i < _ctx.Length("ListDataCorrectPreCheckDB.PreCheckDBList.Length"); i++) {
				ListDataCorrectPreCheckDBResponse.ListDataCorrectPreCheckDB_PreCheckDB preCheckDB = new ListDataCorrectPreCheckDBResponse.ListDataCorrectPreCheckDB_PreCheckDB();
				preCheckDB.DbId = _ctx.LongValue("ListDataCorrectPreCheckDB.PreCheckDBList["+ i +"].DbId");
				preCheckDB.SearchName = _ctx.StringValue("ListDataCorrectPreCheckDB.PreCheckDBList["+ i +"].SearchName");
				preCheckDB.SqlNum = _ctx.LongValue("ListDataCorrectPreCheckDB.PreCheckDBList["+ i +"].SqlNum");

				listDataCorrectPreCheckDBResponse_preCheckDBList.Add(preCheckDB);
			}
			listDataCorrectPreCheckDBResponse.PreCheckDBList = listDataCorrectPreCheckDBResponse_preCheckDBList;
        
			return listDataCorrectPreCheckDBResponse;
        }
    }
}
