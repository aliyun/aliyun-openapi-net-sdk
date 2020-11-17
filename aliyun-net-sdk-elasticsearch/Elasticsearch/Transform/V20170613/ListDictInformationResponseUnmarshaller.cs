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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListDictInformationResponseUnmarshaller
    {
        public static ListDictInformationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDictInformationResponse listDictInformationResponse = new ListDictInformationResponse();

			listDictInformationResponse.HttpResponse = _ctx.HttpResponse;
			listDictInformationResponse.RequestId = _ctx.StringValue("ListDictInformation.RequestId");

			ListDictInformationResponse.ListDictInformation_Result result = new ListDictInformationResponse.ListDictInformation_Result();
			result.FileSize = _ctx.LongValue("ListDictInformation.Result.fileSize");
			result.Type = _ctx.StringValue("ListDictInformation.Result.type");

			ListDictInformationResponse.ListDictInformation_Result.ListDictInformation_OssObject ossObject = new ListDictInformationResponse.ListDictInformation_Result.ListDictInformation_OssObject();
			ossObject.BucketName = _ctx.StringValue("ListDictInformation.Result.OssObject.bucketName");
			ossObject.Key = _ctx.StringValue("ListDictInformation.Result.OssObject.key");
			ossObject.Etag = _ctx.StringValue("ListDictInformation.Result.OssObject.etag");
			result.OssObject = ossObject;
			listDictInformationResponse.Result = result;
        
			return listDictInformationResponse;
        }
    }
}
