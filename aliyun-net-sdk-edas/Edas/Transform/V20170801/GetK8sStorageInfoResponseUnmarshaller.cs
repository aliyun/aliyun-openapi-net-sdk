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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class GetK8sStorageInfoResponseUnmarshaller
    {
        public static GetK8sStorageInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetK8sStorageInfoResponse getK8sStorageInfoResponse = new GetK8sStorageInfoResponse();

			getK8sStorageInfoResponse.HttpResponse = _ctx.HttpResponse;
			getK8sStorageInfoResponse.Code = _ctx.IntegerValue("GetK8sStorageInfo.Code");
			getK8sStorageInfoResponse.Message = _ctx.StringValue("GetK8sStorageInfo.Message");
			getK8sStorageInfoResponse.RequestId = _ctx.StringValue("GetK8sStorageInfo.RequestId");

			GetK8sStorageInfoResponse.GetK8sStorageInfo_StorageInfo storageInfo = new GetK8sStorageInfoResponse.GetK8sStorageInfo_StorageInfo();
			storageInfo.VolumePlugin = _ctx.StringValue("GetK8sStorageInfo.StorageInfo.VolumePlugin");
			getK8sStorageInfoResponse.StorageInfo = storageInfo;
        
			return getK8sStorageInfoResponse;
        }
    }
}
