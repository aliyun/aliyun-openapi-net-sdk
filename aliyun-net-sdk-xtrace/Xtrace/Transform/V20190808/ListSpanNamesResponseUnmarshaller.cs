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
using Aliyun.Acs.xtrace.Model.V20190808;

namespace Aliyun.Acs.xtrace.Transform.V20190808
{
    public class ListSpanNamesResponseUnmarshaller
    {
        public static ListSpanNamesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSpanNamesResponse listSpanNamesResponse = new ListSpanNamesResponse();

			listSpanNamesResponse.HttpResponse = _ctx.HttpResponse;
			listSpanNamesResponse.RequestId = _ctx.StringValue("ListSpanNames.RequestId");

			List<string> listSpanNamesResponse_spanNames = new List<string>();
			for (int i = 0; i < _ctx.Length("ListSpanNames.SpanNames.Length"); i++) {
				listSpanNamesResponse_spanNames.Add(_ctx.StringValue("ListSpanNames.SpanNames["+ i +"]"));
			}
			listSpanNamesResponse.SpanNames = listSpanNamesResponse_spanNames;
        
			return listSpanNamesResponse;
        }
    }
}
