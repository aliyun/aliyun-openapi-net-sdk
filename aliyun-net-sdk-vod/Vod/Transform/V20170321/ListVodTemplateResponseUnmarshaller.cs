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
    public class ListVodTemplateResponseUnmarshaller
    {
        public static ListVodTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			ListVodTemplateResponse listVodTemplateResponse = new ListVodTemplateResponse();

			listVodTemplateResponse.HttpResponse = context.HttpResponse;
			listVodTemplateResponse.RequestId = context.StringValue("ListVodTemplate.RequestId");

			List<ListVodTemplateResponse.ListVodTemplate_VodTemplateInfo> listVodTemplateResponse_vodTemplateInfoList = new List<ListVodTemplateResponse.ListVodTemplate_VodTemplateInfo>();
			for (int i = 0; i < context.Length("ListVodTemplate.VodTemplateInfoList.Length"); i++) {
				ListVodTemplateResponse.ListVodTemplate_VodTemplateInfo vodTemplateInfo = new ListVodTemplateResponse.ListVodTemplate_VodTemplateInfo();
				vodTemplateInfo.Name = context.StringValue("ListVodTemplate.VodTemplateInfoList["+ i +"].Name");
				vodTemplateInfo.VodTemplateId = context.StringValue("ListVodTemplate.VodTemplateInfoList["+ i +"].VodTemplateId");
				vodTemplateInfo.TemplateType = context.StringValue("ListVodTemplate.VodTemplateInfoList["+ i +"].TemplateType");
				vodTemplateInfo.SubTemplateType = context.StringValue("ListVodTemplate.VodTemplateInfoList["+ i +"].SubTemplateType");
				vodTemplateInfo.Source = context.StringValue("ListVodTemplate.VodTemplateInfoList["+ i +"].Source");
				vodTemplateInfo.IsDefault = context.StringValue("ListVodTemplate.VodTemplateInfoList["+ i +"].IsDefault");
				vodTemplateInfo.TemplateConfig = context.StringValue("ListVodTemplate.VodTemplateInfoList["+ i +"].TemplateConfig");
				vodTemplateInfo.CreationTime = context.StringValue("ListVodTemplate.VodTemplateInfoList["+ i +"].CreationTime");
				vodTemplateInfo.ModifyTime = context.StringValue("ListVodTemplate.VodTemplateInfoList["+ i +"].ModifyTime");
				vodTemplateInfo.AppId = context.StringValue("ListVodTemplate.VodTemplateInfoList["+ i +"].AppId");

				listVodTemplateResponse_vodTemplateInfoList.Add(vodTemplateInfo);
			}
			listVodTemplateResponse.VodTemplateInfoList = listVodTemplateResponse_vodTemplateInfoList;
        
			return listVodTemplateResponse;
        }
    }
}
