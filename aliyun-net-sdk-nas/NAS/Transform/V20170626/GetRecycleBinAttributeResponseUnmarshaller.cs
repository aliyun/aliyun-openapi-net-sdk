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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class GetRecycleBinAttributeResponseUnmarshaller
    {
        public static GetRecycleBinAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRecycleBinAttributeResponse getRecycleBinAttributeResponse = new GetRecycleBinAttributeResponse();

			getRecycleBinAttributeResponse.HttpResponse = _ctx.HttpResponse;
			getRecycleBinAttributeResponse.RequestId = _ctx.StringValue("GetRecycleBinAttribute.RequestId");

			GetRecycleBinAttributeResponse.GetRecycleBinAttribute_RecycleBinAttribute recycleBinAttribute = new GetRecycleBinAttributeResponse.GetRecycleBinAttribute_RecycleBinAttribute();
			recycleBinAttribute.Size = _ctx.LongValue("GetRecycleBinAttribute.RecycleBinAttribute.Size");
			recycleBinAttribute.SecondarySize = _ctx.LongValue("GetRecycleBinAttribute.RecycleBinAttribute.SecondarySize");
			recycleBinAttribute.Status = _ctx.StringValue("GetRecycleBinAttribute.RecycleBinAttribute.Status");
			recycleBinAttribute.ReservedDays = _ctx.LongValue("GetRecycleBinAttribute.RecycleBinAttribute.ReservedDays");
			recycleBinAttribute.EnableTime = _ctx.StringValue("GetRecycleBinAttribute.RecycleBinAttribute.EnableTime");
			getRecycleBinAttributeResponse.RecycleBinAttribute = recycleBinAttribute;
        
			return getRecycleBinAttributeResponse;
        }
    }
}
