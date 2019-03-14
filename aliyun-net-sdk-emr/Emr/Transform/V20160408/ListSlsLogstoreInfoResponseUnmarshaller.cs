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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class ListSlsLogstoreInfoResponseUnmarshaller
    {
        public static ListSlsLogstoreInfoResponse Unmarshall(UnmarshallerContext context)
        {
			ListSlsLogstoreInfoResponse listSlsLogstoreInfoResponse = new ListSlsLogstoreInfoResponse();

			listSlsLogstoreInfoResponse.HttpResponse = context.HttpResponse;
			listSlsLogstoreInfoResponse.RequestId = context.StringValue("ListSlsLogstoreInfo.RequestId");

			List<ListSlsLogstoreInfoResponse.ListSlsLogstoreInfo_SlsLogstoreInfo> listSlsLogstoreInfoResponse_slsLogstoreInfoList = new List<ListSlsLogstoreInfoResponse.ListSlsLogstoreInfo_SlsLogstoreInfo>();
			for (int i = 0; i < context.Length("ListSlsLogstoreInfo.SlsLogstoreInfoList.Length"); i++) {
				ListSlsLogstoreInfoResponse.ListSlsLogstoreInfo_SlsLogstoreInfo slsLogstoreInfo = new ListSlsLogstoreInfoResponse.ListSlsLogstoreInfo_SlsLogstoreInfo();
				slsLogstoreInfo.Id = context.LongValue("ListSlsLogstoreInfo.SlsLogstoreInfoList["+ i +"].Id");
				slsLogstoreInfo.ServiceName = context.StringValue("ListSlsLogstoreInfo.SlsLogstoreInfoList["+ i +"].ServiceName");
				slsLogstoreInfo.ComponentName = context.StringValue("ListSlsLogstoreInfo.SlsLogstoreInfoList["+ i +"].ComponentName");
				slsLogstoreInfo.LogstoreName = context.StringValue("ListSlsLogstoreInfo.SlsLogstoreInfoList["+ i +"].LogstoreName");
				slsLogstoreInfo.LogType = context.StringValue("ListSlsLogstoreInfo.SlsLogstoreInfoList["+ i +"].LogType");

				listSlsLogstoreInfoResponse_slsLogstoreInfoList.Add(slsLogstoreInfo);
			}
			listSlsLogstoreInfoResponse.SlsLogstoreInfoList = listSlsLogstoreInfoResponse_slsLogstoreInfoList;
        
			return listSlsLogstoreInfoResponse;
        }
    }
}
