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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class ListFpShotDBResponseUnmarshaller
    {
        public static ListFpShotDBResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListFpShotDBResponse listFpShotDBResponse = new ListFpShotDBResponse();

			listFpShotDBResponse.HttpResponse = _ctx.HttpResponse;
			listFpShotDBResponse.RequestId = _ctx.StringValue("ListFpShotDB.RequestId");

			List<string> listFpShotDBResponse_nonExistIds = new List<string>();
			for (int i = 0; i < _ctx.Length("ListFpShotDB.NonExistIds.Length"); i++) {
				listFpShotDBResponse_nonExistIds.Add(_ctx.StringValue("ListFpShotDB.NonExistIds["+ i +"]"));
			}
			listFpShotDBResponse.NonExistIds = listFpShotDBResponse_nonExistIds;

			List<ListFpShotDBResponse.ListFpShotDB_FpShotDB> listFpShotDBResponse_fpShotDBList = new List<ListFpShotDBResponse.ListFpShotDB_FpShotDB>();
			for (int i = 0; i < _ctx.Length("ListFpShotDB.FpShotDBList.Length"); i++) {
				ListFpShotDBResponse.ListFpShotDB_FpShotDB fpShotDB = new ListFpShotDBResponse.ListFpShotDB_FpShotDB();
				fpShotDB.Status = _ctx.StringValue("ListFpShotDB.FpShotDBList["+ i +"].Status");
				fpShotDB.Description = _ctx.StringValue("ListFpShotDB.FpShotDBList["+ i +"].Description");
				fpShotDB.Name = _ctx.StringValue("ListFpShotDB.FpShotDBList["+ i +"].Name");
				fpShotDB.ModelId = _ctx.IntegerValue("ListFpShotDB.FpShotDBList["+ i +"].ModelId");
				fpShotDB.FpDBId = _ctx.StringValue("ListFpShotDB.FpShotDBList["+ i +"].FpDBId");
				fpShotDB.InstanceId = _ctx.StringValue("ListFpShotDB.FpShotDBList["+ i +"].InstanceId");

				listFpShotDBResponse_fpShotDBList.Add(fpShotDB);
			}
			listFpShotDBResponse.FpShotDBList = listFpShotDBResponse_fpShotDBList;
        
			return listFpShotDBResponse;
        }
    }
}
