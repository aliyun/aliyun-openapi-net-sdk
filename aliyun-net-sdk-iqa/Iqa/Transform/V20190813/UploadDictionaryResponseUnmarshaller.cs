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
using Aliyun.Acs.iqa.Model.V20190813;

namespace Aliyun.Acs.iqa.Transform.V20190813
{
    public class UploadDictionaryResponseUnmarshaller
    {
        public static UploadDictionaryResponse Unmarshall(UnmarshallerContext context)
        {
			UploadDictionaryResponse uploadDictionaryResponse = new UploadDictionaryResponse();

			uploadDictionaryResponse.HttpResponse = context.HttpResponse;
			uploadDictionaryResponse.RequestId = context.StringValue("UploadDictionary.RequestId");
			uploadDictionaryResponse.ProjectId = context.StringValue("UploadDictionary.ProjectId");
			uploadDictionaryResponse.TotalCount = context.IntegerValue("UploadDictionary.TotalCount");
			uploadDictionaryResponse.FileDataCount = context.IntegerValue("UploadDictionary.FileDataCount");
			uploadDictionaryResponse.JsonDataCount = context.IntegerValue("UploadDictionary.JsonDataCount");
        
			return uploadDictionaryResponse;
        }
    }
}
