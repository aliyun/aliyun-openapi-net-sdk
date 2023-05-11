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
    public class QueryDevicePictureFileResponseUnmarshaller
    {
        public static QueryDevicePictureFileResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDevicePictureFileResponse queryDevicePictureFileResponse = new QueryDevicePictureFileResponse();

			queryDevicePictureFileResponse.HttpResponse = _ctx.HttpResponse;
			queryDevicePictureFileResponse.Code = _ctx.StringValue("QueryDevicePictureFile.Code");
			queryDevicePictureFileResponse.RequestId = _ctx.StringValue("QueryDevicePictureFile.RequestId");
			queryDevicePictureFileResponse.ErrorMessage = _ctx.StringValue("QueryDevicePictureFile.ErrorMessage");
			queryDevicePictureFileResponse.Success = _ctx.BooleanValue("QueryDevicePictureFile.Success");

			QueryDevicePictureFileResponse.QueryDevicePictureFile_Data data = new QueryDevicePictureFileResponse.QueryDevicePictureFile_Data();
			data.PicId = _ctx.StringValue("QueryDevicePictureFile.Data.PicId");
			data.PicUrl = _ctx.StringValue("QueryDevicePictureFile.Data.PicUrl");
			data.PicCreateTime = _ctx.LongValue("QueryDevicePictureFile.Data.PicCreateTime");
			data.ThumbUrl = _ctx.StringValue("QueryDevicePictureFile.Data.ThumbUrl");
			data.IotId = _ctx.StringValue("QueryDevicePictureFile.Data.IotId");
			queryDevicePictureFileResponse.Data = data;
        
			return queryDevicePictureFileResponse;
        }
    }
}
