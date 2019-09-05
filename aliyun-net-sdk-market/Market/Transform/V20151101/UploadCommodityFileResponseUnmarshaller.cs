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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class UploadCommodityFileResponseUnmarshaller
    {
        public static UploadCommodityFileResponse Unmarshall(UnmarshallerContext context)
        {
			UploadCommodityFileResponse uploadCommodityFileResponse = new UploadCommodityFileResponse();

			uploadCommodityFileResponse.HttpResponse = context.HttpResponse;
			uploadCommodityFileResponse.RequestId = context.StringValue("UploadCommodityFile.RequestId");
			uploadCommodityFileResponse.Success = context.BooleanValue("UploadCommodityFile.Success");

			UploadCommodityFileResponse.UploadCommodityFile_Data data = new UploadCommodityFileResponse.UploadCommodityFile_Data();
			data.ResourceType = context.StringValue("UploadCommodityFile.Data.ResourceType");
			data.Resource = context.StringValue("UploadCommodityFile.Data.Resource");
			uploadCommodityFileResponse.Data = data;
        
			return uploadCommodityFileResponse;
        }
    }
}
