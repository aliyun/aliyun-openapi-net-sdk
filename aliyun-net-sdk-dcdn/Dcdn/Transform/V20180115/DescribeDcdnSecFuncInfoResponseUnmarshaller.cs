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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnSecFuncInfoResponseUnmarshaller
    {
        public static DescribeDcdnSecFuncInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnSecFuncInfoResponse describeDcdnSecFuncInfoResponse = new DescribeDcdnSecFuncInfoResponse();

			describeDcdnSecFuncInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnSecFuncInfoResponse.RequestId = _ctx.StringValue("DescribeDcdnSecFuncInfo.RequestId");
			describeDcdnSecFuncInfoResponse.Description = _ctx.StringValue("DescribeDcdnSecFuncInfo.Description");
			describeDcdnSecFuncInfoResponse.RetCode = _ctx.StringValue("DescribeDcdnSecFuncInfo.RetCode");
			describeDcdnSecFuncInfoResponse.HttpStatus = _ctx.StringValue("DescribeDcdnSecFuncInfo.HttpStatus");

			List<DescribeDcdnSecFuncInfoResponse.DescribeDcdnSecFuncInfo_ContentItem> describeDcdnSecFuncInfoResponse_content = new List<DescribeDcdnSecFuncInfoResponse.DescribeDcdnSecFuncInfo_ContentItem>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnSecFuncInfo.Content.Length"); i++) {
				DescribeDcdnSecFuncInfoResponse.DescribeDcdnSecFuncInfo_ContentItem contentItem = new DescribeDcdnSecFuncInfoResponse.DescribeDcdnSecFuncInfo_ContentItem();
				contentItem.Label = _ctx.StringValue("DescribeDcdnSecFuncInfo.Content["+ i +"].Label");
				contentItem._Value = _ctx.StringValue("DescribeDcdnSecFuncInfo.Content["+ i +"].Value");

				describeDcdnSecFuncInfoResponse_content.Add(contentItem);
			}
			describeDcdnSecFuncInfoResponse.Content = describeDcdnSecFuncInfoResponse_content;
        
			return describeDcdnSecFuncInfoResponse;
        }
    }
}
