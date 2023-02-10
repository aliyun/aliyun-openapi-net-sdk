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
using Aliyun.Acs.es_serverless.Model.V20220822;

namespace Aliyun.Acs.es_serverless.Transform.V20220822
{
    public class GetDataStreamResponseUnmarshaller
    {
        public static GetDataStreamResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDataStreamResponse getDataStreamResponse = new GetDataStreamResponse();

			getDataStreamResponse.HttpResponse = _ctx.HttpResponse;
			getDataStreamResponse.RequestId = _ctx.StringValue("GetDataStream.requestId");

			GetDataStreamResponse.GetDataStream_Result result = new GetDataStreamResponse.GetDataStream_Result();
			result.AppName = _ctx.StringValue("GetDataStream.Result.appName");
			result.RegionId = _ctx.StringValue("GetDataStream.Result.regionId");
			result.DeletePhase = _ctx.StringValue("GetDataStream.Result.deletePhase");
			result.DataStreamId = _ctx.StringValue("GetDataStream.Result.dataStreamId");
			result.DataStreamName = _ctx.StringValue("GetDataStream.Result.dataStreamName");
			result.Type = _ctx.StringValue("GetDataStream.Result.type");
			result.CreateTime = _ctx.StringValue("GetDataStream.Result.createTime");
			result.TimeStampKey = _ctx.StringValue("GetDataStream.Result.timeStampKey");

			GetDataStreamResponse.GetDataStream_Result.GetDataStream_Template template = new GetDataStreamResponse.GetDataStream_Result.GetDataStream_Template();

			List<GetDataStreamResponse.GetDataStream_Result.GetDataStream_Template.GetDataStream_MappingsItem> template_mappings = new List<GetDataStreamResponse.GetDataStream_Result.GetDataStream_Template.GetDataStream_MappingsItem>();
			for (int i = 0; i < _ctx.Length("GetDataStream.Result.Template.Mappings.Length"); i++) {
				GetDataStreamResponse.GetDataStream_Result.GetDataStream_Template.GetDataStream_MappingsItem mappingsItem = new GetDataStreamResponse.GetDataStream_Result.GetDataStream_Template.GetDataStream_MappingsItem();
				mappingsItem.Type = _ctx.StringValue("GetDataStream.Result.Template.Mappings["+ i +"].type");
				mappingsItem.CaseSensitive = _ctx.BooleanValue("GetDataStream.Result.Template.Mappings["+ i +"].caseSensitive");
				mappingsItem.DocValues = _ctx.BooleanValue("GetDataStream.Result.Template.Mappings["+ i +"].docValues");
				mappingsItem.Index = _ctx.BooleanValue("GetDataStream.Result.Template.Mappings["+ i +"].index");
				mappingsItem.Key = _ctx.StringValue("GetDataStream.Result.Template.Mappings["+ i +"].key");

				List<string> mappingsItem_tokenizeOnChars = new List<string>();
				for (int j = 0; j < _ctx.Length("GetDataStream.Result.Template.Mappings["+ i +"].TokenizeOnChars.Length"); j++) {
					mappingsItem_tokenizeOnChars.Add(_ctx.StringValue("GetDataStream.Result.Template.Mappings["+ i +"].TokenizeOnChars["+ j +"]"));
				}
				mappingsItem.TokenizeOnChars = mappingsItem_tokenizeOnChars;

				List<string> mappingsItem_properties = new List<string>();
				for (int j = 0; j < _ctx.Length("GetDataStream.Result.Template.Mappings["+ i +"].Properties.Length"); j++) {
					mappingsItem_properties.Add(_ctx.StringValue("GetDataStream.Result.Template.Mappings["+ i +"].Properties["+ j +"]"));
				}
				mappingsItem.Properties = mappingsItem_properties;

				template_mappings.Add(mappingsItem);
			}
			template.Mappings = template_mappings;
			result.Template = template;
			getDataStreamResponse.Result = result;
        
			return getDataStreamResponse;
        }
    }
}
