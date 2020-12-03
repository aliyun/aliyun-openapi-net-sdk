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
using Aliyun.Acs.imageprocess.Model.V20200320;

namespace Aliyun.Acs.imageprocess.Transform.V20200320
{
    public class ClassifyFNFResponseUnmarshaller
    {
        public static ClassifyFNFResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ClassifyFNFResponse classifyFNFResponse = new ClassifyFNFResponse();

			classifyFNFResponse.HttpResponse = _ctx.HttpResponse;
			classifyFNFResponse.RequestId = _ctx.StringValue("ClassifyFNF.RequestId");

			ClassifyFNFResponse.ClassifyFNF_Data data = new ClassifyFNFResponse.ClassifyFNF_Data();
			data.ImageUrl = _ctx.StringValue("ClassifyFNF.Data.ImageUrl");
			data.OrgId = _ctx.StringValue("ClassifyFNF.Data.OrgId");
			data.OrgName = _ctx.StringValue("ClassifyFNF.Data.OrgName");

			List<ClassifyFNFResponse.ClassifyFNF_Data.ClassifyFNF_FracturesItem> data_fractures = new List<ClassifyFNFResponse.ClassifyFNF_Data.ClassifyFNF_FracturesItem>();
			for (int i = 0; i < _ctx.Length("ClassifyFNF.Data.Fractures.Length"); i++) {
				ClassifyFNFResponse.ClassifyFNF_Data.ClassifyFNF_FracturesItem fracturesItem = new ClassifyFNFResponse.ClassifyFNF_Data.ClassifyFNF_FracturesItem();
				fracturesItem._Value = _ctx.FloatValue("ClassifyFNF.Data.Fractures["+ i +"].Value");

				List<string> fracturesItem_boxes = new List<string>();
				for (int j = 0; j < _ctx.Length("ClassifyFNF.Data.Fractures["+ i +"].Boxes.Length"); j++) {
					fracturesItem_boxes.Add(_ctx.StringValue("ClassifyFNF.Data.Fractures["+ i +"].Boxes["+ j +"]"));
				}
				fracturesItem.Boxes = fracturesItem_boxes;

				ClassifyFNFResponse.ClassifyFNF_Data.ClassifyFNF_FracturesItem.ClassifyFNF_Tag tag = new ClassifyFNFResponse.ClassifyFNF_Data.ClassifyFNF_FracturesItem.ClassifyFNF_Tag();
				tag.Label = _ctx.StringValue("ClassifyFNF.Data.Fractures["+ i +"].Tag.Label");
				fracturesItem.Tag = tag;

				data_fractures.Add(fracturesItem);
			}
			data.Fractures = data_fractures;
			classifyFNFResponse.Data = data;
        
			return classifyFNFResponse;
        }
    }
}
