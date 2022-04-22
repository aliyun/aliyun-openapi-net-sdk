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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QuerySoundCodeLabelBatchFailedResultResponseUnmarshaller
    {
        public static QuerySoundCodeLabelBatchFailedResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySoundCodeLabelBatchFailedResultResponse querySoundCodeLabelBatchFailedResultResponse = new QuerySoundCodeLabelBatchFailedResultResponse();

			querySoundCodeLabelBatchFailedResultResponse.HttpResponse = _ctx.HttpResponse;
			querySoundCodeLabelBatchFailedResultResponse.RequestId = _ctx.StringValue("QuerySoundCodeLabelBatchFailedResult.RequestId");
			querySoundCodeLabelBatchFailedResultResponse.Success = _ctx.BooleanValue("QuerySoundCodeLabelBatchFailedResult.Success");
			querySoundCodeLabelBatchFailedResultResponse.Code = _ctx.StringValue("QuerySoundCodeLabelBatchFailedResult.Code");
			querySoundCodeLabelBatchFailedResultResponse.ErrorMessage = _ctx.StringValue("QuerySoundCodeLabelBatchFailedResult.ErrorMessage");

			List<QuerySoundCodeLabelBatchFailedResultResponse.QuerySoundCodeLabelBatchFailedResult_Items> querySoundCodeLabelBatchFailedResultResponse_data = new List<QuerySoundCodeLabelBatchFailedResultResponse.QuerySoundCodeLabelBatchFailedResult_Items>();
			for (int i = 0; i < _ctx.Length("QuerySoundCodeLabelBatchFailedResult.Data.Length"); i++) {
				QuerySoundCodeLabelBatchFailedResultResponse.QuerySoundCodeLabelBatchFailedResult_Items items = new QuerySoundCodeLabelBatchFailedResultResponse.QuerySoundCodeLabelBatchFailedResult_Items();
				items.ResultCode = _ctx.StringValue("QuerySoundCodeLabelBatchFailedResult.Data["+ i +"].ResultCode");
				items.Label = _ctx.StringValue("QuerySoundCodeLabelBatchFailedResult.Data["+ i +"].Label");
				items.ErrorMessage = _ctx.StringValue("QuerySoundCodeLabelBatchFailedResult.Data["+ i +"].ErrorMessage");

				querySoundCodeLabelBatchFailedResultResponse_data.Add(items);
			}
			querySoundCodeLabelBatchFailedResultResponse.Data = querySoundCodeLabelBatchFailedResultResponse_data;
        
			return querySoundCodeLabelBatchFailedResultResponse;
        }
    }
}
