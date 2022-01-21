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
    public class ListDataCorrectPreCheckSQLResponseUnmarshaller
    {
        public static ListDataCorrectPreCheckSQLResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataCorrectPreCheckSQLResponse listDataCorrectPreCheckSQLResponse = new ListDataCorrectPreCheckSQLResponse();

			listDataCorrectPreCheckSQLResponse.HttpResponse = _ctx.HttpResponse;
			listDataCorrectPreCheckSQLResponse.RequestId = _ctx.StringValue("ListDataCorrectPreCheckSQL.RequestId");
			listDataCorrectPreCheckSQLResponse.Success = _ctx.BooleanValue("ListDataCorrectPreCheckSQL.Success");
			listDataCorrectPreCheckSQLResponse.ErrorMessage = _ctx.StringValue("ListDataCorrectPreCheckSQL.ErrorMessage");
			listDataCorrectPreCheckSQLResponse.ErrorCode = _ctx.StringValue("ListDataCorrectPreCheckSQL.ErrorCode");

			List<ListDataCorrectPreCheckSQLResponse.ListDataCorrectPreCheckSQL_PreCheckSQL> listDataCorrectPreCheckSQLResponse_preCheckSQLList = new List<ListDataCorrectPreCheckSQLResponse.ListDataCorrectPreCheckSQL_PreCheckSQL>();
			for (int i = 0; i < _ctx.Length("ListDataCorrectPreCheckSQL.PreCheckSQLList.Length"); i++) {
				ListDataCorrectPreCheckSQLResponse.ListDataCorrectPreCheckSQL_PreCheckSQL preCheckSQL = new ListDataCorrectPreCheckSQLResponse.ListDataCorrectPreCheckSQL_PreCheckSQL();
				preCheckSQL.CheckSQL = _ctx.StringValue("ListDataCorrectPreCheckSQL.PreCheckSQLList["+ i +"].CheckSQL");
				preCheckSQL.AffectRows = _ctx.LongValue("ListDataCorrectPreCheckSQL.PreCheckSQLList["+ i +"].AffectRows");
				preCheckSQL.DbId = _ctx.LongValue("ListDataCorrectPreCheckSQL.PreCheckSQLList["+ i +"].DbId");
				preCheckSQL.SQLReviewQueryKey = _ctx.StringValue("ListDataCorrectPreCheckSQL.PreCheckSQLList["+ i +"].SQLReviewQueryKey");
				preCheckSQL.SqlReviewStatus = _ctx.StringValue("ListDataCorrectPreCheckSQL.PreCheckSQLList["+ i +"].SqlReviewStatus");
				preCheckSQL.SqlType = _ctx.StringValue("ListDataCorrectPreCheckSQL.PreCheckSQLList["+ i +"].SqlType");
				preCheckSQL.TableNames = _ctx.StringValue("ListDataCorrectPreCheckSQL.PreCheckSQLList["+ i +"].TableNames");

				listDataCorrectPreCheckSQLResponse_preCheckSQLList.Add(preCheckSQL);
			}
			listDataCorrectPreCheckSQLResponse.PreCheckSQLList = listDataCorrectPreCheckSQLResponse_preCheckSQLList;
        
			return listDataCorrectPreCheckSQLResponse;
        }
    }
}
