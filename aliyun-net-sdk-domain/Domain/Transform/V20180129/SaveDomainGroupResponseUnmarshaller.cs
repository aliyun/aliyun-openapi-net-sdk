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
    public class SaveDomainGroupResponseUnmarshaller
    {
        public static SaveDomainGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SaveDomainGroupResponse saveDomainGroupResponse = new SaveDomainGroupResponse();

			saveDomainGroupResponse.HttpResponse = _ctx.HttpResponse;
			saveDomainGroupResponse.RequestId = _ctx.StringValue("SaveDomainGroup.RequestId");
			saveDomainGroupResponse.DomainGroupId = _ctx.LongValue("SaveDomainGroup.DomainGroupId");
			saveDomainGroupResponse.DomainGroupName = _ctx.StringValue("SaveDomainGroup.DomainGroupName");
			saveDomainGroupResponse.TotalNumber = _ctx.IntegerValue("SaveDomainGroup.TotalNumber");
			saveDomainGroupResponse.CreationDate = _ctx.StringValue("SaveDomainGroup.CreationDate");
			saveDomainGroupResponse.ModificationDate = _ctx.StringValue("SaveDomainGroup.ModificationDate");
			saveDomainGroupResponse.DomainGroupStatus = _ctx.StringValue("SaveDomainGroup.DomainGroupStatus");
			saveDomainGroupResponse.BeingDeleted = _ctx.BooleanValue("SaveDomainGroup.BeingDeleted");
        
			return saveDomainGroupResponse;
        }
    }
}
