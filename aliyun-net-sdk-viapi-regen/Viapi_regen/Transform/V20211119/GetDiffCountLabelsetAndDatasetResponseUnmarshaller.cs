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
using Aliyun.Acs.viapi_regen.Model.V20211119;

namespace Aliyun.Acs.viapi_regen.Transform.V20211119
{
    public class GetDiffCountLabelsetAndDatasetResponseUnmarshaller
    {
        public static GetDiffCountLabelsetAndDatasetResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDiffCountLabelsetAndDatasetResponse getDiffCountLabelsetAndDatasetResponse = new GetDiffCountLabelsetAndDatasetResponse();

			getDiffCountLabelsetAndDatasetResponse.HttpResponse = _ctx.HttpResponse;
			getDiffCountLabelsetAndDatasetResponse.Message = _ctx.StringValue("GetDiffCountLabelsetAndDataset.Message");
			getDiffCountLabelsetAndDatasetResponse.RequestId = _ctx.StringValue("GetDiffCountLabelsetAndDataset.RequestId");
			getDiffCountLabelsetAndDatasetResponse.Code = _ctx.StringValue("GetDiffCountLabelsetAndDataset.Code");

			GetDiffCountLabelsetAndDatasetResponse.GetDiffCountLabelsetAndDataset_Data data = new GetDiffCountLabelsetAndDatasetResponse.GetDiffCountLabelsetAndDataset_Data();
			data.DiffCount = _ctx.LongValue("GetDiffCountLabelsetAndDataset.Data.DiffCount");
			getDiffCountLabelsetAndDatasetResponse.Data = data;
        
			return getDiffCountLabelsetAndDatasetResponse;
        }
    }
}
