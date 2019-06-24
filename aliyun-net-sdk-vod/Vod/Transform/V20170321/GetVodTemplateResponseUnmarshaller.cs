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
    public class GetVodTemplateResponseUnmarshaller
    {
        public static GetVodTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			GetVodTemplateResponse getVodTemplateResponse = new GetVodTemplateResponse();

			getVodTemplateResponse.HttpResponse = context.HttpResponse;
			getVodTemplateResponse.RequestId = context.StringValue("GetVodTemplate.RequestId");

			GetVodTemplateResponse.GetVodTemplate_VodTemplateInfo vodTemplateInfo = new GetVodTemplateResponse.GetVodTemplate_VodTemplateInfo();
			vodTemplateInfo.Name = context.StringValue("GetVodTemplate.VodTemplateInfo.Name");
			vodTemplateInfo.VodTemplateId = context.StringValue("GetVodTemplate.VodTemplateInfo.VodTemplateId");
			vodTemplateInfo.TemplateType = context.StringValue("GetVodTemplate.VodTemplateInfo.TemplateType");
			vodTemplateInfo.SubTemplateType = context.StringValue("GetVodTemplate.VodTemplateInfo.SubTemplateType");
			vodTemplateInfo.Source = context.StringValue("GetVodTemplate.VodTemplateInfo.Source");
			vodTemplateInfo.IsDefault = context.StringValue("GetVodTemplate.VodTemplateInfo.IsDefault");
			vodTemplateInfo.TemplateConfig = context.StringValue("GetVodTemplate.VodTemplateInfo.TemplateConfig");
			vodTemplateInfo.CreationTime = context.StringValue("GetVodTemplate.VodTemplateInfo.CreationTime");
			vodTemplateInfo.ModifyTime = context.StringValue("GetVodTemplate.VodTemplateInfo.ModifyTime");
			getVodTemplateResponse.VodTemplateInfo = vodTemplateInfo;
        
			return getVodTemplateResponse;
        }
    }
}
