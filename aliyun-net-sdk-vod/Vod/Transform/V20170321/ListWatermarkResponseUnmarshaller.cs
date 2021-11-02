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
    public class ListWatermarkResponseUnmarshaller
    {
        public static ListWatermarkResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListWatermarkResponse listWatermarkResponse = new ListWatermarkResponse();

			listWatermarkResponse.HttpResponse = _ctx.HttpResponse;
			listWatermarkResponse.RequestId = _ctx.StringValue("ListWatermark.RequestId");

			List<ListWatermarkResponse.ListWatermark_WatermarkInfo> listWatermarkResponse_watermarkInfos = new List<ListWatermarkResponse.ListWatermark_WatermarkInfo>();
			for (int i = 0; i < _ctx.Length("ListWatermark.WatermarkInfos.Length"); i++) {
				ListWatermarkResponse.ListWatermark_WatermarkInfo watermarkInfo = new ListWatermarkResponse.ListWatermark_WatermarkInfo();
				watermarkInfo.CreationTime = _ctx.StringValue("ListWatermark.WatermarkInfos["+ i +"].CreationTime");
				watermarkInfo.Type = _ctx.StringValue("ListWatermark.WatermarkInfos["+ i +"].Type");
				watermarkInfo.IsDefault = _ctx.StringValue("ListWatermark.WatermarkInfos["+ i +"].IsDefault");
				watermarkInfo.WatermarkId = _ctx.StringValue("ListWatermark.WatermarkInfos["+ i +"].WatermarkId");
				watermarkInfo.Name = _ctx.StringValue("ListWatermark.WatermarkInfos["+ i +"].Name");
				watermarkInfo.FileUrl = _ctx.StringValue("ListWatermark.WatermarkInfos["+ i +"].FileUrl");
				watermarkInfo.WatermarkConfig = _ctx.StringValue("ListWatermark.WatermarkInfos["+ i +"].WatermarkConfig");
				watermarkInfo.AppId = _ctx.StringValue("ListWatermark.WatermarkInfos["+ i +"].AppId");

				listWatermarkResponse_watermarkInfos.Add(watermarkInfo);
			}
			listWatermarkResponse.WatermarkInfos = listWatermarkResponse_watermarkInfos;
        
			return listWatermarkResponse;
        }
    }
}
