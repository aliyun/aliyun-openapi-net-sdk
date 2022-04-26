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
using Aliyun.Acs.CCC.Model.V20200701;

namespace Aliyun.Acs.CCC.Transform.V20200701
{
    public class ImportCustomCallTaggingResponseUnmarshaller
    {
        public static ImportCustomCallTaggingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ImportCustomCallTaggingResponse importCustomCallTaggingResponse = new ImportCustomCallTaggingResponse();

			importCustomCallTaggingResponse.HttpResponse = _ctx.HttpResponse;
			importCustomCallTaggingResponse.RequestId = _ctx.StringValue("ImportCustomCallTagging.RequestId");
			importCustomCallTaggingResponse.HttpStatusCode = _ctx.IntegerValue("ImportCustomCallTagging.HttpStatusCode");
			importCustomCallTaggingResponse.Code = _ctx.StringValue("ImportCustomCallTagging.Code");
			importCustomCallTaggingResponse.Message = _ctx.StringValue("ImportCustomCallTagging.Message");

			List<ImportCustomCallTaggingResponse.ImportCustomCallTagging_FailureItem> importCustomCallTaggingResponse_data = new List<ImportCustomCallTaggingResponse.ImportCustomCallTagging_FailureItem>();
			for (int i = 0; i < _ctx.Length("ImportCustomCallTagging.Data.Length"); i++) {
				ImportCustomCallTaggingResponse.ImportCustomCallTagging_FailureItem failureItem = new ImportCustomCallTaggingResponse.ImportCustomCallTagging_FailureItem();
				failureItem.Item = _ctx.StringValue("ImportCustomCallTagging.Data["+ i +"].Item");
				failureItem.Reason = _ctx.StringValue("ImportCustomCallTagging.Data["+ i +"].Reason");

				importCustomCallTaggingResponse_data.Add(failureItem);
			}
			importCustomCallTaggingResponse.Data = importCustomCallTaggingResponse_data;
        
			return importCustomCallTaggingResponse;
        }
    }
}
