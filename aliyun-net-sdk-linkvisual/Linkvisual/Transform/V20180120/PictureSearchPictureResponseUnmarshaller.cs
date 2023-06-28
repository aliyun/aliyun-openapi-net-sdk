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
    public class PictureSearchPictureResponseUnmarshaller
    {
        public static PictureSearchPictureResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PictureSearchPictureResponse pictureSearchPictureResponse = new PictureSearchPictureResponse();

			pictureSearchPictureResponse.HttpResponse = _ctx.HttpResponse;
			pictureSearchPictureResponse.Code = _ctx.StringValue("PictureSearchPicture.Code");
			pictureSearchPictureResponse.ErrorMessage = _ctx.StringValue("PictureSearchPicture.ErrorMessage");
			pictureSearchPictureResponse.RequestId = _ctx.StringValue("PictureSearchPicture.RequestId");
			pictureSearchPictureResponse.Success = _ctx.BooleanValue("PictureSearchPicture.Success");

			PictureSearchPictureResponse.PictureSearchPicture_Data data = new PictureSearchPictureResponse.PictureSearchPicture_Data();
			data.CurrentPage = _ctx.IntegerValue("PictureSearchPicture.Data.CurrentPage");
			data.PageSize = _ctx.IntegerValue("PictureSearchPicture.Data.PageSize");
			data.Total = _ctx.IntegerValue("PictureSearchPicture.Data.Total");
			data.PageCount = _ctx.IntegerValue("PictureSearchPicture.Data.PageCount");

			List<PictureSearchPictureResponse.PictureSearchPicture_Data.PictureSearchPicture_SearchData> data_pageData = new List<PictureSearchPictureResponse.PictureSearchPicture_Data.PictureSearchPicture_SearchData>();
			for (int i = 0; i < _ctx.Length("PictureSearchPicture.Data.PageData.Length"); i++) {
				PictureSearchPictureResponse.PictureSearchPicture_Data.PictureSearchPicture_SearchData searchData = new PictureSearchPictureResponse.PictureSearchPicture_Data.PictureSearchPicture_SearchData();
				searchData.PicUrl = _ctx.StringValue("PictureSearchPicture.Data.PageData["+ i +"].PicUrl");
				searchData.EventTime = _ctx.LongValue("PictureSearchPicture.Data.PageData["+ i +"].EventTime");
				searchData.GatewayIotId = _ctx.StringValue("PictureSearchPicture.Data.PageData["+ i +"].GatewayIotId");
				searchData.VectorId = _ctx.StringValue("PictureSearchPicture.Data.PageData["+ i +"].VectorId");
				searchData.Threshold = _ctx.FloatValue("PictureSearchPicture.Data.PageData["+ i +"].Threshold");
				searchData.VectorType = _ctx.IntegerValue("PictureSearchPicture.Data.PageData["+ i +"].VectorType");
				searchData.IotId = _ctx.StringValue("PictureSearchPicture.Data.PageData["+ i +"].IotId");

				data_pageData.Add(searchData);
			}
			data.PageData = data_pageData;
			pictureSearchPictureResponse.Data = data;
        
			return pictureSearchPictureResponse;
        }
    }
}
