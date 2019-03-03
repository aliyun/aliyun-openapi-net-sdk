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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Chatbot.Model.V20171011
{
	public class DescribeIntentResponse : AcsResponse
	{
        public new string RequestId { get; set; }

        public long? IntentId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public long? DialogId { get; set; }

        public string CreateTime { get; set; }

        public string ModifyTime { get; set; }

        public string CreateUserId { get; set; }

        public string CreateUserName { get; set; }

        public string ModifyUserId { get; set; }

        public string ModifyUserName { get; set; }

        public List<DescribeIntent_RuleCheckItem> RuleCheck { get; set; }

        public List<DescribeIntent_SlotItem> Slot { get; set; }

        public List<DescribeIntent_UserSayItem> UserSay { get; set; }

        public class DescribeIntent_RuleCheckItem
		{
            public string Text { get; set; }

            public bool? Strict { get; set; }

            public List<string> Warning { get; set; }

            public List<string> Error { get; set; }
        }

		public class DescribeIntent_SlotItem
		{
            public string Name { get; set; }

            public string _Value { get; set; }

            public bool? IsNecessary { get; set; }

            public bool? IsArray { get; set; }

            public int? LifeSpan { get; set; }

            public List<DescribeIntent_TagsItem> Tags { get; set; }

            public List<string> Question { get; set; }

            public class DescribeIntent_TagsItem
			{
                public string _Value { get; set; }

                public string UserSayId { get; set; }
            }
		}

		public class DescribeIntent_UserSayItem
		{
            public bool? Strict { get; set; }

            public List<DescribeIntent_DataItem> Data { get; set; }

            public class DescribeIntent_DataItem
			{
                public string Text { get; set; }

                public string SlotId { get; set; }
            }
		}
	}
}