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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class ListMediaResponseUnmarshaller
    {
        public static ListMediaResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMediaResponse listMediaResponse = new ListMediaResponse();

			listMediaResponse.HttpResponse = _ctx.HttpResponse;
			listMediaResponse.Code = _ctx.StringValue("ListMedia.Code");
			listMediaResponse.Success = _ctx.BooleanValue("ListMedia.Success");
			listMediaResponse.Message = _ctx.StringValue("ListMedia.Message");
			listMediaResponse.RequestId = _ctx.StringValue("ListMedia.RequestId");
			listMediaResponse.PageNumber = _ctx.IntegerValue("ListMedia.PageNumber");
			listMediaResponse.PageSize = _ctx.IntegerValue("ListMedia.PageSize");
			listMediaResponse.Total = _ctx.LongValue("ListMedia.Total");

			List<ListMediaResponse.ListMedia_Media> listMediaResponse_model = new List<ListMediaResponse.ListMedia_Media>();
			for (int i = 0; i < _ctx.Length("ListMedia.Model.Length"); i++) {
				ListMediaResponse.ListMedia_Media media = new ListMediaResponse.ListMedia_Media();
				media.CreateTime = _ctx.LongValue("ListMedia.Model["+ i +"].CreateTime");
				media.ModifyTime = _ctx.LongValue("ListMedia.Model["+ i +"].ModifyTime");
				media.TenantId = _ctx.StringValue("ListMedia.Model["+ i +"].TenantId");
				media.MediaName = _ctx.StringValue("ListMedia.Model["+ i +"].MediaName");
				media.MediaId = _ctx.StringValue("ListMedia.Model["+ i +"].MediaId");
				media.MediaType = _ctx.StringValue("ListMedia.Model["+ i +"].MediaType");
				media.FirstScene = _ctx.StringValue("ListMedia.Model["+ i +"].FirstScene");
				media.SecondScene = _ctx.StringValue("ListMedia.Model["+ i +"].SecondScene");
				media.MediaStatus = _ctx.StringValue("ListMedia.Model["+ i +"].MediaStatus");
				media.AccessStatus = _ctx.StringValue("ListMedia.Model["+ i +"].AccessStatus");
				media.Os = _ctx.StringValue("ListMedia.Model["+ i +"].Os");
				media.Config = _ctx.StringValue("ListMedia.Model["+ i +"].Config");
				media.KeyWords = _ctx.StringValue("ListMedia.Model["+ i +"].KeyWords");
				media.AccessWay = _ctx.StringValue("ListMedia.Model["+ i +"].AccessWay");
				media.ExtInfo = _ctx.StringValue("ListMedia.Model["+ i +"].ExtInfo");
				media.Version = _ctx.LongValue("ListMedia.Model["+ i +"].Version");

				listMediaResponse_model.Add(media);
			}
			listMediaResponse.Model = listMediaResponse_model;
        
			return listMediaResponse;
        }
    }
}
