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
using Aliyun.Acs.hitsdb.Model.V20200615;

namespace Aliyun.Acs.hitsdb.Transform.V20200615
{
    public class GetLindormInstanceEngineListResponseUnmarshaller
    {
        public static GetLindormInstanceEngineListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetLindormInstanceEngineListResponse getLindormInstanceEngineListResponse = new GetLindormInstanceEngineListResponse();

			getLindormInstanceEngineListResponse.HttpResponse = _ctx.HttpResponse;
			getLindormInstanceEngineListResponse.RequestId = _ctx.StringValue("GetLindormInstanceEngineList.RequestId");
			getLindormInstanceEngineListResponse.InstanceId = _ctx.StringValue("GetLindormInstanceEngineList.InstanceId");

			List<GetLindormInstanceEngineListResponse.GetLindormInstanceEngineList_EngineInfo> getLindormInstanceEngineListResponse_engineList = new List<GetLindormInstanceEngineListResponse.GetLindormInstanceEngineList_EngineInfo>();
			for (int i = 0; i < _ctx.Length("GetLindormInstanceEngineList.EngineList.Length"); i++) {
				GetLindormInstanceEngineListResponse.GetLindormInstanceEngineList_EngineInfo engineInfo = new GetLindormInstanceEngineListResponse.GetLindormInstanceEngineList_EngineInfo();
				engineInfo.EngineType = _ctx.StringValue("GetLindormInstanceEngineList.EngineList["+ i +"].EngineType");

				List<GetLindormInstanceEngineListResponse.GetLindormInstanceEngineList_EngineInfo.GetLindormInstanceEngineList_NetInfo> engineInfo_netInfoList = new List<GetLindormInstanceEngineListResponse.GetLindormInstanceEngineList_EngineInfo.GetLindormInstanceEngineList_NetInfo>();
				for (int j = 0; j < _ctx.Length("GetLindormInstanceEngineList.EngineList["+ i +"].NetInfoList.Length"); j++) {
					GetLindormInstanceEngineListResponse.GetLindormInstanceEngineList_EngineInfo.GetLindormInstanceEngineList_NetInfo netInfo = new GetLindormInstanceEngineListResponse.GetLindormInstanceEngineList_EngineInfo.GetLindormInstanceEngineList_NetInfo();
					netInfo.NetType = _ctx.StringValue("GetLindormInstanceEngineList.EngineList["+ i +"].NetInfoList["+ j +"].NetType");
					netInfo.ConnectionString = _ctx.StringValue("GetLindormInstanceEngineList.EngineList["+ i +"].NetInfoList["+ j +"].ConnectionString");
					netInfo.Port = _ctx.IntegerValue("GetLindormInstanceEngineList.EngineList["+ i +"].NetInfoList["+ j +"].Port");
					netInfo.AccessType = _ctx.IntegerValue("GetLindormInstanceEngineList.EngineList["+ i +"].NetInfoList["+ j +"].AccessType");

					engineInfo_netInfoList.Add(netInfo);
				}
				engineInfo.NetInfoList = engineInfo_netInfoList;

				getLindormInstanceEngineListResponse_engineList.Add(engineInfo);
			}
			getLindormInstanceEngineListResponse.EngineList = getLindormInstanceEngineListResponse_engineList;
        
			return getLindormInstanceEngineListResponse;
        }
    }
}
