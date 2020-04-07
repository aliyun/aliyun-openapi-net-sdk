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
    public class ListFpShotNotaryResponseUnmarshaller
    {
        public static ListFpShotNotaryResponse Unmarshall(UnmarshallerContext context)
        {
			ListFpShotNotaryResponse listFpShotNotaryResponse = new ListFpShotNotaryResponse();

			listFpShotNotaryResponse.HttpResponse = context.HttpResponse;
			listFpShotNotaryResponse.RequestId = context.StringValue("ListFpShotNotary.RequestId");
			listFpShotNotaryResponse.NextPageToken = context.StringValue("ListFpShotNotary.NextPageToken");

			List<ListFpShotNotaryResponse.ListFpShotNotary_FpShotNotary> listFpShotNotaryResponse_fpShotNotaryList = new List<ListFpShotNotaryResponse.ListFpShotNotary_FpShotNotary>();
			for (int i = 0; i < context.Length("ListFpShotNotary.FpShotNotaryList.Length"); i++) {
				ListFpShotNotaryResponse.ListFpShotNotary_FpShotNotary fpShotNotary = new ListFpShotNotaryResponse.ListFpShotNotary_FpShotNotary();
				fpShotNotary.TransactionId = context.StringValue("ListFpShotNotary.FpShotNotaryList["+ i +"].TransactionId");
				fpShotNotary.TxHash = context.StringValue("ListFpShotNotary.FpShotNotaryList["+ i +"].TxHash");
				fpShotNotary.FpDBId = context.StringValue("ListFpShotNotary.FpShotNotaryList["+ i +"].FpDBId");
				fpShotNotary.JobId = context.StringValue("ListFpShotNotary.FpShotNotaryList["+ i +"].JobId");
				fpShotNotary.Detail = context.StringValue("ListFpShotNotary.FpShotNotaryList["+ i +"].Detail");
				fpShotNotary.CreationTime = context.StringValue("ListFpShotNotary.FpShotNotaryList["+ i +"].CreationTime");
				fpShotNotary.FinishTime = context.StringValue("ListFpShotNotary.FpShotNotaryList["+ i +"].FinishTime");

				listFpShotNotaryResponse_fpShotNotaryList.Add(fpShotNotary);
			}
			listFpShotNotaryResponse.FpShotNotaryList = listFpShotNotaryResponse_fpShotNotaryList;
        
			return listFpShotNotaryResponse;
        }
    }
}
