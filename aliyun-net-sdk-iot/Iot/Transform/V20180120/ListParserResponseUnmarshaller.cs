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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class ListParserResponseUnmarshaller
    {
        public static ListParserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListParserResponse listParserResponse = new ListParserResponse();

			listParserResponse.HttpResponse = _ctx.HttpResponse;
			listParserResponse.RequestId = _ctx.StringValue("ListParser.RequestId");
			listParserResponse.Success = _ctx.BooleanValue("ListParser.Success");
			listParserResponse.Code = _ctx.StringValue("ListParser.Code");
			listParserResponse.ErrorMessage = _ctx.StringValue("ListParser.ErrorMessage");
			listParserResponse.Total = _ctx.IntegerValue("ListParser.Total");

			List<ListParserResponse.ListParser_ParserList> listParserResponse_data = new List<ListParserResponse.ListParser_ParserList>();
			for (int i = 0; i < _ctx.Length("ListParser.Data.Length"); i++) {
				ListParserResponse.ListParser_ParserList parserList = new ListParserResponse.ListParser_ParserList();
				parserList.Name = _ctx.StringValue("ListParser.Data["+ i +"].Name");
				parserList.ParserId = _ctx.LongValue("ListParser.Data["+ i +"].ParserId");
				parserList.Description = _ctx.StringValue("ListParser.Data["+ i +"].Description");
				parserList.Status = _ctx.StringValue("ListParser.Data["+ i +"].Status");
				parserList.UtcCreated = _ctx.StringValue("ListParser.Data["+ i +"].UtcCreated");
				parserList.UtcModified = _ctx.StringValue("ListParser.Data["+ i +"].UtcModified");

				listParserResponse_data.Add(parserList);
			}
			listParserResponse.Data = listParserResponse_data;
        
			return listParserResponse;
        }
    }
}
