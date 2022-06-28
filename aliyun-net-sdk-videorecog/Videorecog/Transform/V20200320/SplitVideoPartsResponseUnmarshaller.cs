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
using Aliyun.Acs.videorecog.Model.V20200320;

namespace Aliyun.Acs.videorecog.Transform.V20200320
{
    public class SplitVideoPartsResponseUnmarshaller
    {
        public static SplitVideoPartsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SplitVideoPartsResponse splitVideoPartsResponse = new SplitVideoPartsResponse();

			splitVideoPartsResponse.HttpResponse = _ctx.HttpResponse;
			splitVideoPartsResponse.RequestId = _ctx.StringValue("SplitVideoParts.RequestId");
			splitVideoPartsResponse.Code = _ctx.StringValue("SplitVideoParts.Code");
			splitVideoPartsResponse.Message = _ctx.StringValue("SplitVideoParts.Message");

			SplitVideoPartsResponse.SplitVideoParts_Data data = new SplitVideoPartsResponse.SplitVideoParts_Data();

			List<SplitVideoPartsResponse.SplitVideoParts_Data.SplitVideoParts_ElementsItem> data_elements = new List<SplitVideoPartsResponse.SplitVideoParts_Data.SplitVideoParts_ElementsItem>();
			for (int i = 0; i < _ctx.Length("SplitVideoParts.Data.Elements.Length"); i++) {
				SplitVideoPartsResponse.SplitVideoParts_Data.SplitVideoParts_ElementsItem elementsItem = new SplitVideoPartsResponse.SplitVideoParts_Data.SplitVideoParts_ElementsItem();
				elementsItem.BeginTime = _ctx.FloatValue("SplitVideoParts.Data.Elements["+ i +"].BeginTime");
				elementsItem.EndTime = _ctx.FloatValue("SplitVideoParts.Data.Elements["+ i +"].EndTime");
				elementsItem.Index = _ctx.LongValue("SplitVideoParts.Data.Elements["+ i +"].Index");

				data_elements.Add(elementsItem);
			}
			data.Elements = data_elements;
			splitVideoPartsResponse.Data = data;
        
			return splitVideoPartsResponse;
        }
    }
}
