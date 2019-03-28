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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeLaunchTemplatesResponseUnmarshaller
    {
        public static DescribeLaunchTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLaunchTemplatesResponse describeLaunchTemplatesResponse = new DescribeLaunchTemplatesResponse();

			describeLaunchTemplatesResponse.HttpResponse = context.HttpResponse;
			describeLaunchTemplatesResponse.RequestId = context.StringValue("DescribeLaunchTemplates.RequestId");
			describeLaunchTemplatesResponse.TotalCount = context.IntegerValue("DescribeLaunchTemplates.TotalCount");
			describeLaunchTemplatesResponse.PageNumber = context.IntegerValue("DescribeLaunchTemplates.PageNumber");
			describeLaunchTemplatesResponse.PageSize = context.IntegerValue("DescribeLaunchTemplates.PageSize");

			List<DescribeLaunchTemplatesResponse.DescribeLaunchTemplates_LaunchTemplateSet> describeLaunchTemplatesResponse_launchTemplateSets = new List<DescribeLaunchTemplatesResponse.DescribeLaunchTemplates_LaunchTemplateSet>();
			for (int i = 0; i < context.Length("DescribeLaunchTemplates.LaunchTemplateSets.Length"); i++) {
				DescribeLaunchTemplatesResponse.DescribeLaunchTemplates_LaunchTemplateSet launchTemplateSet = new DescribeLaunchTemplatesResponse.DescribeLaunchTemplates_LaunchTemplateSet();
				launchTemplateSet.CreateTime = context.StringValue("DescribeLaunchTemplates.LaunchTemplateSets["+ i +"].CreateTime");
				launchTemplateSet.ModifiedTime = context.StringValue("DescribeLaunchTemplates.LaunchTemplateSets["+ i +"].ModifiedTime");
				launchTemplateSet.LaunchTemplateId = context.StringValue("DescribeLaunchTemplates.LaunchTemplateSets["+ i +"].LaunchTemplateId");
				launchTemplateSet.LaunchTemplateName = context.StringValue("DescribeLaunchTemplates.LaunchTemplateSets["+ i +"].LaunchTemplateName");
				launchTemplateSet.DefaultVersionNumber = context.LongValue("DescribeLaunchTemplates.LaunchTemplateSets["+ i +"].DefaultVersionNumber");
				launchTemplateSet.LatestVersionNumber = context.LongValue("DescribeLaunchTemplates.LaunchTemplateSets["+ i +"].LatestVersionNumber");
				launchTemplateSet.CreatedBy = context.StringValue("DescribeLaunchTemplates.LaunchTemplateSets["+ i +"].CreatedBy");
				launchTemplateSet.ResourceGroupId = context.StringValue("DescribeLaunchTemplates.LaunchTemplateSets["+ i +"].ResourceGroupId");

				List<DescribeLaunchTemplatesResponse.DescribeLaunchTemplates_LaunchTemplateSet.DescribeLaunchTemplates_Tag> launchTemplateSet_tags = new List<DescribeLaunchTemplatesResponse.DescribeLaunchTemplates_LaunchTemplateSet.DescribeLaunchTemplates_Tag>();
				for (int j = 0; j < context.Length("DescribeLaunchTemplates.LaunchTemplateSets["+ i +"].Tags.Length"); j++) {
					DescribeLaunchTemplatesResponse.DescribeLaunchTemplates_LaunchTemplateSet.DescribeLaunchTemplates_Tag tag = new DescribeLaunchTemplatesResponse.DescribeLaunchTemplates_LaunchTemplateSet.DescribeLaunchTemplates_Tag();
					tag.TagKey = context.StringValue("DescribeLaunchTemplates.LaunchTemplateSets["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeLaunchTemplates.LaunchTemplateSets["+ i +"].Tags["+ j +"].TagValue");

					launchTemplateSet_tags.Add(tag);
				}
				launchTemplateSet.Tags = launchTemplateSet_tags;

				describeLaunchTemplatesResponse_launchTemplateSets.Add(launchTemplateSet);
			}
			describeLaunchTemplatesResponse.LaunchTemplateSets = describeLaunchTemplatesResponse_launchTemplateSets;
        
			return describeLaunchTemplatesResponse;
        }
    }
}
