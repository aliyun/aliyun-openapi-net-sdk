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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class ListNodeTransferPacketPathsResponseUnmarshaller
    {
        public static ListNodeTransferPacketPathsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListNodeTransferPacketPathsResponse listNodeTransferPacketPathsResponse = new ListNodeTransferPacketPathsResponse();

			listNodeTransferPacketPathsResponse.HttpResponse = _ctx.HttpResponse;
			listNodeTransferPacketPathsResponse.RequestId = _ctx.StringValue("ListNodeTransferPacketPaths.RequestId");
			listNodeTransferPacketPathsResponse.Success = _ctx.BooleanValue("ListNodeTransferPacketPaths.Success");

			ListNodeTransferPacketPathsResponse.ListNodeTransferPacketPaths_Data data = new ListNodeTransferPacketPathsResponse.ListNodeTransferPacketPaths_Data();
			data.TotalCount = _ctx.LongValue("ListNodeTransferPacketPaths.Data.TotalCount");

			List<ListNodeTransferPacketPathsResponse.ListNodeTransferPacketPaths_Data.ListNodeTransferPacketPaths_Path> data_list = new List<ListNodeTransferPacketPathsResponse.ListNodeTransferPacketPaths_Data.ListNodeTransferPacketPaths_Path>();
			for (int i = 0; i < _ctx.Length("ListNodeTransferPacketPaths.Data.List.Length"); i++) {
				ListNodeTransferPacketPathsResponse.ListNodeTransferPacketPaths_Data.ListNodeTransferPacketPaths_Path path = new ListNodeTransferPacketPathsResponse.ListNodeTransferPacketPaths_Data.ListNodeTransferPacketPaths_Path();
				path.GwEui = _ctx.StringValue("ListNodeTransferPacketPaths.Data.List["+ i +"].GwEui");
				path.DevEui = _ctx.StringValue("ListNodeTransferPacketPaths.Data.List["+ i +"].DevEui");
				path.Rssi = _ctx.IntegerValue("ListNodeTransferPacketPaths.Data.List["+ i +"].Rssi");
				path.Lsnr = _ctx.FloatValue("ListNodeTransferPacketPaths.Data.List["+ i +"].Lsnr");
				path.BestPath = _ctx.BooleanValue("ListNodeTransferPacketPaths.Data.List["+ i +"].BestPath");

				data_list.Add(path);
			}
			data.List = data_list;
			listNodeTransferPacketPathsResponse.Data = data;
        
			return listNodeTransferPacketPathsResponse;
        }
    }
}
