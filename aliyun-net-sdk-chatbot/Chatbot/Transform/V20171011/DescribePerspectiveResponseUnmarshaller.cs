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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Chatbot.Model.V20171011;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Transform.V20171011
{
    public class DescribePerspectiveResponseUnmarshaller
    {
        public static DescribePerspectiveResponse Unmarshall(UnmarshallerContext context)
        {
            DescribePerspectiveResponse describePerspectiveResponse = new DescribePerspectiveResponse
            {
                HttpResponse = context.HttpResponse,
                ModifyUserName = context.StringValue("DescribePerspective.ModifyUserName"),
                ModifyTime = context.StringValue("DescribePerspective.ModifyTime"),
                CreateTime = context.StringValue("DescribePerspective.CreateTime"),
                SelfDefine = context.BooleanValue("DescribePerspective.SelfDefine"),
                PerspectiveId = context.StringValue("DescribePerspective.PerspectiveId"),
                CreateUserName = context.StringValue("DescribePerspective.CreateUserName"),
                PerspectiveCode = context.StringValue("DescribePerspective.PerspectiveCode"),
                Status = context.IntegerValue("DescribePerspective.Status"),
                RequestId = context.StringValue("DescribePerspective.RequestId"),
                Name = context.StringValue("DescribePerspective.Name")
            };

            return describePerspectiveResponse;
        }
    }
}