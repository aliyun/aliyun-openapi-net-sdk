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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListAliyunRegionResponseUnmarshaller
    {
        public static ListAliyunRegionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAliyunRegionResponse listAliyunRegionResponse = new ListAliyunRegionResponse();

			listAliyunRegionResponse.HttpResponse = _ctx.HttpResponse;
			listAliyunRegionResponse.Code = _ctx.IntegerValue("ListAliyunRegion.Code");
			listAliyunRegionResponse.Message = _ctx.StringValue("ListAliyunRegion.Message");
			listAliyunRegionResponse.RequestId = _ctx.StringValue("ListAliyunRegion.RequestId");

			List<ListAliyunRegionResponse.ListAliyunRegion_RegionEntity> listAliyunRegionResponse_regionEntityList = new List<ListAliyunRegionResponse.ListAliyunRegion_RegionEntity>();
			for (int i = 0; i < _ctx.Length("ListAliyunRegion.RegionEntityList.Length"); i++) {
				ListAliyunRegionResponse.ListAliyunRegion_RegionEntity regionEntity = new ListAliyunRegionResponse.ListAliyunRegion_RegionEntity();
				regionEntity.Id = _ctx.StringValue("ListAliyunRegion.RegionEntityList["+ i +"].Id");
				regionEntity.Name = _ctx.StringValue("ListAliyunRegion.RegionEntityList["+ i +"].Name");

				listAliyunRegionResponse_regionEntityList.Add(regionEntity);
			}
			listAliyunRegionResponse.RegionEntityList = listAliyunRegionResponse_regionEntityList;
        
			return listAliyunRegionResponse;
        }
    }
}
