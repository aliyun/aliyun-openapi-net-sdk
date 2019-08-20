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
using Aliyun.Acs.AppMallsService.Model.V20180224;

namespace Aliyun.Acs.AppMallsService.Transform.V20180224
{
    public class TaobaoFilmGetRegionListResponseUnmarshaller
    {
        public static TaobaoFilmGetRegionListResponse Unmarshall(UnmarshallerContext context)
        {
			TaobaoFilmGetRegionListResponse taobaoFilmGetRegionListResponse = new TaobaoFilmGetRegionListResponse();

			taobaoFilmGetRegionListResponse.HttpResponse = context.HttpResponse;
			taobaoFilmGetRegionListResponse.ErrorCode = context.StringValue("TaobaoFilmGetRegionList.ErrorCode");
			taobaoFilmGetRegionListResponse.Msg = context.StringValue("TaobaoFilmGetRegionList.Msg");
			taobaoFilmGetRegionListResponse.SubCode = context.StringValue("TaobaoFilmGetRegionList.SubCode");
			taobaoFilmGetRegionListResponse.SubMsg = context.StringValue("TaobaoFilmGetRegionList.SubMsg");
			taobaoFilmGetRegionListResponse.LogsId = context.StringValue("TaobaoFilmGetRegionList.LogsId");
			taobaoFilmGetRegionListResponse.RequestId = context.StringValue("TaobaoFilmGetRegionList.RequestId");

			List<TaobaoFilmGetRegionListResponse.TaobaoFilmGetRegionList_RegionsItem> taobaoFilmGetRegionListResponse_regions = new List<TaobaoFilmGetRegionListResponse.TaobaoFilmGetRegionList_RegionsItem>();
			for (int i = 0; i < context.Length("TaobaoFilmGetRegionList.Regions.Length"); i++) {
				TaobaoFilmGetRegionListResponse.TaobaoFilmGetRegionList_RegionsItem regionsItem = new TaobaoFilmGetRegionListResponse.TaobaoFilmGetRegionList_RegionsItem();
				regionsItem.CityCode = context.LongValue("TaobaoFilmGetRegionList.Regions["+ i +"].CityCode");
				regionsItem.Id = context.LongValue("TaobaoFilmGetRegionList.Regions["+ i +"].Id");
				regionsItem.ParentId = context.LongValue("TaobaoFilmGetRegionList.Regions["+ i +"].ParentId");
				regionsItem.PinYin = context.StringValue("TaobaoFilmGetRegionList.Regions["+ i +"].PinYin");
				regionsItem.RegionName = context.StringValue("TaobaoFilmGetRegionList.Regions["+ i +"].RegionName");

				taobaoFilmGetRegionListResponse_regions.Add(regionsItem);
			}
			taobaoFilmGetRegionListResponse.Regions = taobaoFilmGetRegionListResponse_regions;
        
			return taobaoFilmGetRegionListResponse;
        }
    }
}
