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
    public class ListDataStreamsResponseUnmarshaller
    {
        public static ListDataStreamsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataStreamsResponse listDataStreamsResponse = new ListDataStreamsResponse();

			listDataStreamsResponse.HttpResponse = _ctx.HttpResponse;
			listDataStreamsResponse.RequestId = _ctx.StringValue("ListDataStreams.requestId");
			listDataStreamsResponse.TotalCount = _ctx.IntegerValue("ListDataStreams.totalCount");

			List<ListDataStreamsResponse.ListDataStreams_DataStream> listDataStreamsResponse_result = new List<ListDataStreamsResponse.ListDataStreams_DataStream>();
			for (int i = 0; i < _ctx.Length("ListDataStreams.Result.Length"); i++) {
				ListDataStreamsResponse.ListDataStreams_DataStream dataStream = new ListDataStreamsResponse.ListDataStreams_DataStream();
				dataStream.AppName = _ctx.StringValue("ListDataStreams.Result["+ i +"].appName");
				dataStream.RegionId = _ctx.StringValue("ListDataStreams.Result["+ i +"].regionId");
				dataStream.DeletePhase = _ctx.StringValue("ListDataStreams.Result["+ i +"].deletePhase");
				dataStream.DataStreamName = _ctx.StringValue("ListDataStreams.Result["+ i +"].dataStreamName");
				dataStream.DataStreamId = _ctx.StringValue("ListDataStreams.Result["+ i +"].dataStreamId");
				dataStream.Type = _ctx.StringValue("ListDataStreams.Result["+ i +"].type");
				dataStream.CreateTime = _ctx.StringValue("ListDataStreams.Result["+ i +"].createTime");
				dataStream.TimeStampKey = _ctx.StringValue("ListDataStreams.Result["+ i +"].timeStampKey");

				ListDataStreamsResponse.ListDataStreams_DataStream.ListDataStreams_Template template = new ListDataStreamsResponse.ListDataStreams_DataStream.ListDataStreams_Template();

				List<ListDataStreamsResponse.ListDataStreams_DataStream.ListDataStreams_Template.ListDataStreams_MappingsItem> template_mappings = new List<ListDataStreamsResponse.ListDataStreams_DataStream.ListDataStreams_Template.ListDataStreams_MappingsItem>();
				for (int j = 0; j < _ctx.Length("ListDataStreams.Result["+ i +"].Template.Mappings.Length"); j++) {
					ListDataStreamsResponse.ListDataStreams_DataStream.ListDataStreams_Template.ListDataStreams_MappingsItem mappingsItem = new ListDataStreamsResponse.ListDataStreams_DataStream.ListDataStreams_Template.ListDataStreams_MappingsItem();
					mappingsItem.Type = _ctx.StringValue("ListDataStreams.Result["+ i +"].Template.Mappings["+ j +"].type");
					mappingsItem.CaseSensitive = _ctx.BooleanValue("ListDataStreams.Result["+ i +"].Template.Mappings["+ j +"].caseSensitive");
					mappingsItem.DocValues = _ctx.BooleanValue("ListDataStreams.Result["+ i +"].Template.Mappings["+ j +"].docValues");
					mappingsItem.Index = _ctx.BooleanValue("ListDataStreams.Result["+ i +"].Template.Mappings["+ j +"].index");
					mappingsItem.Key = _ctx.StringValue("ListDataStreams.Result["+ i +"].Template.Mappings["+ j +"].key");

					List<string> mappingsItem_tokenizeOnChars = new List<string>();
					for (int k = 0; k < _ctx.Length("ListDataStreams.Result["+ i +"].Template.Mappings["+ j +"].TokenizeOnChars.Length"); k++) {
						mappingsItem_tokenizeOnChars.Add(_ctx.StringValue("ListDataStreams.Result["+ i +"].Template.Mappings["+ j +"].TokenizeOnChars["+ k +"]"));
					}
					mappingsItem.TokenizeOnChars = mappingsItem_tokenizeOnChars;

					List<string> mappingsItem_properties = new List<string>();
					for (int k = 0; k < _ctx.Length("ListDataStreams.Result["+ i +"].Template.Mappings["+ j +"].Properties.Length"); k++) {
						mappingsItem_properties.Add(_ctx.StringValue("ListDataStreams.Result["+ i +"].Template.Mappings["+ j +"].Properties["+ k +"]"));
					}
					mappingsItem.Properties = mappingsItem_properties;

					template_mappings.Add(mappingsItem);
				}
				template.Mappings = template_mappings;
				dataStream.Template = template;

				listDataStreamsResponse_result.Add(dataStream);
			}
			listDataStreamsResponse.Result = listDataStreamsResponse_result;
        
			return listDataStreamsResponse;
        }
    }
}
