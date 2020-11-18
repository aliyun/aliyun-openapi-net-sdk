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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class CreateKeywordResponseUnmarshaller
    {
        public static CreateKeywordResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateKeywordResponse createKeywordResponse = new CreateKeywordResponse();

			createKeywordResponse.HttpResponse = _ctx.HttpResponse;
			createKeywordResponse.RequestId = _ctx.StringValue("CreateKeyword.RequestId");
			createKeywordResponse.SuccessCount = _ctx.IntegerValue("CreateKeyword.SuccessCount");

			List<string> createKeywordResponse_invalidKeywordList = new List<string>();
			for (int i = 0; i < _ctx.Length("CreateKeyword.InvalidKeywordList.Length"); i++) {
				createKeywordResponse_invalidKeywordList.Add(_ctx.StringValue("CreateKeyword.InvalidKeywordList["+ i +"]"));
			}
			createKeywordResponse.InvalidKeywordList = createKeywordResponse_invalidKeywordList;

			List<CreateKeywordResponse.CreateKeyword_ValidKeyword> createKeywordResponse_validKeywordList = new List<CreateKeywordResponse.CreateKeyword_ValidKeyword>();
			for (int i = 0; i < _ctx.Length("CreateKeyword.ValidKeywordList.Length"); i++) {
				CreateKeywordResponse.CreateKeyword_ValidKeyword validKeyword = new CreateKeywordResponse.CreateKeyword_ValidKeyword();
				validKeyword.Id = _ctx.IntegerValue("CreateKeyword.ValidKeywordList["+ i +"].id");
				validKeyword.Keyword = _ctx.StringValue("CreateKeyword.ValidKeywordList["+ i +"].keyword");

				createKeywordResponse_validKeywordList.Add(validKeyword);
			}
			createKeywordResponse.ValidKeywordList = createKeywordResponse_validKeywordList;
        
			return createKeywordResponse;
        }
    }
}
