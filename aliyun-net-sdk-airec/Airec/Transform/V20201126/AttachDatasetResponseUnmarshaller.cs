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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class AttachDatasetResponseUnmarshaller
    {
        public static AttachDatasetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AttachDatasetResponse attachDatasetResponse = new AttachDatasetResponse();

			attachDatasetResponse.HttpResponse = _ctx.HttpResponse;
			attachDatasetResponse.Code = _ctx.StringValue("AttachDataset.code");
			attachDatasetResponse.Message = _ctx.StringValue("AttachDataset.message");
			attachDatasetResponse.RequestId = _ctx.StringValue("AttachDataset.requestId");

			AttachDatasetResponse.AttachDataset_Result result = new AttachDatasetResponse.AttachDataset_Result();
			result.GmtCreate = _ctx.LongValue("AttachDataset.Result.gmtCreate");
			result.GmtModified = _ctx.LongValue("AttachDataset.Result.gmtModified");
			result.InstanceId = _ctx.StringValue("AttachDataset.Result.instanceId");
			result.State = _ctx.StringValue("AttachDataset.Result.state");
			result.VersionId = _ctx.StringValue("AttachDataset.Result.versionId");
			attachDatasetResponse.Result = result;
        
			return attachDatasetResponse;
        }
    }
}
