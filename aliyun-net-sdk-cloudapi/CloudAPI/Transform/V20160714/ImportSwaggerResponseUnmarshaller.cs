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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class ImportSwaggerResponseUnmarshaller
    {
        public static ImportSwaggerResponse Unmarshall(UnmarshallerContext context)
        {
			ImportSwaggerResponse importSwaggerResponse = new ImportSwaggerResponse();

			importSwaggerResponse.HttpResponse = context.HttpResponse;
			importSwaggerResponse.RequestId = context.StringValue("ImportSwagger.RequestId");

			List<ImportSwaggerResponse.ImportSwagger_ApiImportSwaggerSuccess> importSwaggerResponse_success = new List<ImportSwaggerResponse.ImportSwagger_ApiImportSwaggerSuccess>();
			for (int i = 0; i < context.Length("ImportSwagger.Success.Length"); i++) {
				ImportSwaggerResponse.ImportSwagger_ApiImportSwaggerSuccess apiImportSwaggerSuccess = new ImportSwaggerResponse.ImportSwagger_ApiImportSwaggerSuccess();
				apiImportSwaggerSuccess.Path = context.StringValue("ImportSwagger.Success["+ i +"].Path");
				apiImportSwaggerSuccess.HttpMethod = context.StringValue("ImportSwagger.Success["+ i +"].HttpMethod");
				apiImportSwaggerSuccess.ApiUid = context.StringValue("ImportSwagger.Success["+ i +"].ApiUid");
				apiImportSwaggerSuccess.ApiOperation = context.StringValue("ImportSwagger.Success["+ i +"].ApiOperation");

				importSwaggerResponse_success.Add(apiImportSwaggerSuccess);
			}
			importSwaggerResponse.Success = importSwaggerResponse_success;

			List<ImportSwaggerResponse.ImportSwagger_ApiImportSwaggerFailed> importSwaggerResponse_failed = new List<ImportSwaggerResponse.ImportSwagger_ApiImportSwaggerFailed>();
			for (int i = 0; i < context.Length("ImportSwagger.Failed.Length"); i++) {
				ImportSwaggerResponse.ImportSwagger_ApiImportSwaggerFailed apiImportSwaggerFailed = new ImportSwaggerResponse.ImportSwagger_ApiImportSwaggerFailed();
				apiImportSwaggerFailed.Path = context.StringValue("ImportSwagger.Failed["+ i +"].Path");
				apiImportSwaggerFailed.HttpMethod = context.StringValue("ImportSwagger.Failed["+ i +"].HttpMethod");
				apiImportSwaggerFailed.ErrorMsg = context.StringValue("ImportSwagger.Failed["+ i +"].ErrorMsg");

				importSwaggerResponse_failed.Add(apiImportSwaggerFailed);
			}
			importSwaggerResponse.Failed = importSwaggerResponse_failed;
        
			return importSwaggerResponse;
        }
    }
}