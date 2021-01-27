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
using Aliyun.Acs.alimt.Model.V20181012;

namespace Aliyun.Acs.alimt.Transform.V20181012
{
    public class GetBatchTranslateResponseUnmarshaller
    {
        public static GetBatchTranslateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetBatchTranslateResponse getBatchTranslateResponse = new GetBatchTranslateResponse();

			getBatchTranslateResponse.HttpResponse = _ctx.HttpResponse;
			getBatchTranslateResponse.RequestId = _ctx.StringValue("GetBatchTranslate.RequestId");
			getBatchTranslateResponse.Code = _ctx.IntegerValue("GetBatchTranslate.Code");
			getBatchTranslateResponse.Message = _ctx.StringValue("GetBatchTranslate.Message");

			List<Dictionary<string, string>> getBatchTranslateResponse_translatedList = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("GetBatchTranslate.TranslatedList.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "GetBatchTranslate.TranslatedList["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					getBatchTranslateResponse_translatedList.Add(tmp);
				}
			}
			getBatchTranslateResponse.TranslatedList = getBatchTranslateResponse_translatedList;
        
			return getBatchTranslateResponse;
        }
    }
}
