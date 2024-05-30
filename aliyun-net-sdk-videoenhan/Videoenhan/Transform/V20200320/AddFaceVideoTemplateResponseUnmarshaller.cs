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
using Aliyun.Acs.videoenhan.Model.V20200320;

namespace Aliyun.Acs.videoenhan.Transform.V20200320
{
    public class AddFaceVideoTemplateResponseUnmarshaller
    {
        public static AddFaceVideoTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddFaceVideoTemplateResponse addFaceVideoTemplateResponse = new AddFaceVideoTemplateResponse();

			addFaceVideoTemplateResponse.HttpResponse = _ctx.HttpResponse;
			addFaceVideoTemplateResponse.RequestId = _ctx.StringValue("AddFaceVideoTemplate.RequestId");
			addFaceVideoTemplateResponse.Code = _ctx.StringValue("AddFaceVideoTemplate.Code");
			addFaceVideoTemplateResponse.Message = _ctx.StringValue("AddFaceVideoTemplate.Message");

			AddFaceVideoTemplateResponse.AddFaceVideoTemplate_Date date = new AddFaceVideoTemplateResponse.AddFaceVideoTemplate_Date();
			date.TemplateId = _ctx.StringValue("AddFaceVideoTemplate.Date.TemplateId");
			date.TransResult = _ctx.StringValue("AddFaceVideoTemplate.Date.TransResult");

			List<AddFaceVideoTemplateResponse.AddFaceVideoTemplate_Date.AddFaceVideoTemplate_FaceInfosItem> date_faceInfos = new List<AddFaceVideoTemplateResponse.AddFaceVideoTemplate_Date.AddFaceVideoTemplate_FaceInfosItem>();
			for (int i = 0; i < _ctx.Length("AddFaceVideoTemplate.Date.FaceInfos.Length"); i++) {
				AddFaceVideoTemplateResponse.AddFaceVideoTemplate_Date.AddFaceVideoTemplate_FaceInfosItem faceInfosItem = new AddFaceVideoTemplateResponse.AddFaceVideoTemplate_Date.AddFaceVideoTemplate_FaceInfosItem();
				faceInfosItem.TemplateFaceID = _ctx.StringValue("AddFaceVideoTemplate.Date.FaceInfos["+ i +"].TemplateFaceID");
				faceInfosItem.TemplateFaceURL = _ctx.StringValue("AddFaceVideoTemplate.Date.FaceInfos["+ i +"].TemplateFaceURL");

				date_faceInfos.Add(faceInfosItem);
			}
			date.FaceInfos = date_faceInfos;
			addFaceVideoTemplateResponse.Date = date;
        
			return addFaceVideoTemplateResponse;
        }
    }
}
