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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class ConfirmTransferInEmailResponseUnmarshaller
    {
        public static ConfirmTransferInEmailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ConfirmTransferInEmailResponse confirmTransferInEmailResponse = new ConfirmTransferInEmailResponse();

			confirmTransferInEmailResponse.HttpResponse = _ctx.HttpResponse;
			confirmTransferInEmailResponse.RequestId = _ctx.StringValue("ConfirmTransferInEmail.RequestId");

			List<string> confirmTransferInEmailResponse_successList = new List<string>();
			for (int i = 0; i < _ctx.Length("ConfirmTransferInEmail.SuccessList.Length"); i++) {
				confirmTransferInEmailResponse_successList.Add(_ctx.StringValue("ConfirmTransferInEmail.SuccessList["+ i +"]"));
			}
			confirmTransferInEmailResponse.SuccessList = confirmTransferInEmailResponse_successList;

			List<string> confirmTransferInEmailResponse_failList = new List<string>();
			for (int i = 0; i < _ctx.Length("ConfirmTransferInEmail.FailList.Length"); i++) {
				confirmTransferInEmailResponse_failList.Add(_ctx.StringValue("ConfirmTransferInEmail.FailList["+ i +"]"));
			}
			confirmTransferInEmailResponse.FailList = confirmTransferInEmailResponse_failList;
        
			return confirmTransferInEmailResponse;
        }
    }
}
