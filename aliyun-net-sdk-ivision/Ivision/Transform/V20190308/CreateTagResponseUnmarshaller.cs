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
using Aliyun.Acs.ivision.Model.V20190308;

namespace Aliyun.Acs.ivision.Transform.V20190308
{
    public class CreateTagResponseUnmarshaller
    {
        public static CreateTagResponse Unmarshall(UnmarshallerContext context)
        {
			CreateTagResponse createTagResponse = new CreateTagResponse();

			createTagResponse.HttpResponse = context.HttpResponse;
			createTagResponse.RequestId = context.StringValue("CreateTag.RequestId");

			CreateTagResponse.CreateTag_Tag tag = new CreateTagResponse.CreateTag_Tag();
			tag.ProjectId = context.StringValue("CreateTag.Tag.ProjectId");
			tag.TagId = context.StringValue("CreateTag.Tag.TagId");
			tag.TagName = context.StringValue("CreateTag.Tag.TagName");
			tag.Description = context.StringValue("CreateTag.Tag.Description");
			tag.Count = context.IntegerValue("CreateTag.Tag.Count");
			tag.CreationTime = context.StringValue("CreateTag.Tag.CreationTime");
			createTagResponse.Tag = tag;
        
			return createTagResponse;
        }
    }
}
