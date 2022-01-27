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
    public class SaveSingleTaskForSynchronizingDnsHostResponseUnmarshaller
    {
        public static SaveSingleTaskForSynchronizingDnsHostResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SaveSingleTaskForSynchronizingDnsHostResponse saveSingleTaskForSynchronizingDnsHostResponse = new SaveSingleTaskForSynchronizingDnsHostResponse();

			saveSingleTaskForSynchronizingDnsHostResponse.HttpResponse = _ctx.HttpResponse;
			saveSingleTaskForSynchronizingDnsHostResponse.RequestId = _ctx.StringValue("SaveSingleTaskForSynchronizingDnsHost.RequestId");
			saveSingleTaskForSynchronizingDnsHostResponse.TaskNo = _ctx.StringValue("SaveSingleTaskForSynchronizingDnsHost.TaskNo");
        
			return saveSingleTaskForSynchronizingDnsHostResponse;
        }
    }
}
