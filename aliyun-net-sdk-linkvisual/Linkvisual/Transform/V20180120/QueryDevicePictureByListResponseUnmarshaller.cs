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
using Aliyun.Acs.Linkvisual.Model.V20180120;

namespace Aliyun.Acs.Linkvisual.Transform.V20180120
{
    public class QueryDevicePictureByListResponseUnmarshaller
    {
        public static QueryDevicePictureByListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDevicePictureByListResponse queryDevicePictureByListResponse = new QueryDevicePictureByListResponse();

			queryDevicePictureByListResponse.HttpResponse = _ctx.HttpResponse;
			queryDevicePictureByListResponse.Code = _ctx.StringValue("QueryDevicePictureByList.Code");
			queryDevicePictureByListResponse.ErrorMessage = _ctx.StringValue("QueryDevicePictureByList.ErrorMessage");
			queryDevicePictureByListResponse.RequestId = _ctx.StringValue("QueryDevicePictureByList.RequestId");
			queryDevicePictureByListResponse.Success = _ctx.BooleanValue("QueryDevicePictureByList.Success");

			List<QueryDevicePictureByListResponse.QueryDevicePictureByList_PicData> queryDevicePictureByListResponse_data = new List<QueryDevicePictureByListResponse.QueryDevicePictureByList_PicData>();
			for (int i = 0; i < _ctx.Length("QueryDevicePictureByList.Data.Length"); i++) {
				QueryDevicePictureByListResponse.QueryDevicePictureByList_PicData picData = new QueryDevicePictureByListResponse.QueryDevicePictureByList_PicData();
				picData.PicId = _ctx.StringValue("QueryDevicePictureByList.Data["+ i +"].PicId");
				picData.PicUrl = _ctx.StringValue("QueryDevicePictureByList.Data["+ i +"].PicUrl");
				picData.PicCreateTime = _ctx.LongValue("QueryDevicePictureByList.Data["+ i +"].PicCreateTime");
				picData.ThumbUrl = _ctx.StringValue("QueryDevicePictureByList.Data["+ i +"].ThumbUrl");
				picData.IotId = _ctx.StringValue("QueryDevicePictureByList.Data["+ i +"].IotId");

				queryDevicePictureByListResponse_data.Add(picData);
			}
			queryDevicePictureByListResponse.Data = queryDevicePictureByListResponse_data;
        
			return queryDevicePictureByListResponse;
        }
    }
}
