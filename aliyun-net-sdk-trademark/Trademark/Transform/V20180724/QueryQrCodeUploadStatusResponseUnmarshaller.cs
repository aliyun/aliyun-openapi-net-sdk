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
using Aliyun.Acs.Trademark.Model.V20180724;

namespace Aliyun.Acs.Trademark.Transform.V20180724
{
    public class QueryQrCodeUploadStatusResponseUnmarshaller
    {
        public static QueryQrCodeUploadStatusResponse Unmarshall(UnmarshallerContext context)
        {
			QueryQrCodeUploadStatusResponse queryQrCodeUploadStatusResponse = new QueryQrCodeUploadStatusResponse();

			queryQrCodeUploadStatusResponse.HttpResponse = context.HttpResponse;
			queryQrCodeUploadStatusResponse.RequestId = context.StringValue("QueryQrCodeUploadStatus.RequestId");
			queryQrCodeUploadStatusResponse.OssKey = context.StringValue("QueryQrCodeUploadStatus.OssKey");
			queryQrCodeUploadStatusResponse.OssUrl = context.StringValue("QueryQrCodeUploadStatus.OssUrl");
			queryQrCodeUploadStatusResponse.Status = context.IntegerValue("QueryQrCodeUploadStatus.Status");
			queryQrCodeUploadStatusResponse.Success = context.BooleanValue("QueryQrCodeUploadStatus.Success");
        
			return queryQrCodeUploadStatusResponse;
        }
    }
}
