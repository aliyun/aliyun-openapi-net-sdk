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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.CloudPhoto.Transform;
using Aliyun.Acs.CloudPhoto.Transform.V20170711;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Model.V20170711
{
    public class ListTimeLinesRequest : RpcAcsRequest<ListTimeLinesResponse>
    {
        public ListTimeLinesRequest()
            : base("CloudPhoto", "2017-07-11", "ListTimeLines", "cloudphoto", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private long? cursor;

		private int? photoSize;

		private int? timeLineCount;

		private string libraryId;

		private string storeName;

		private string timeLineUnit;

		private string filterBy;

		private string direction;

		private string order;

		public long? Cursor
		{
			get
			{
				return cursor;
			}
			set	
			{
				cursor = value;
				DictionaryUtil.Add(QueryParameters, "Cursor", value.ToString());
			}
		}

		public int? PhotoSize
		{
			get
			{
				return photoSize;
			}
			set	
			{
				photoSize = value;
				DictionaryUtil.Add(QueryParameters, "PhotoSize", value.ToString());
			}
		}

		public int? TimeLineCount
		{
			get
			{
				return timeLineCount;
			}
			set	
			{
				timeLineCount = value;
				DictionaryUtil.Add(QueryParameters, "TimeLineCount", value.ToString());
			}
		}

		public string LibraryId
		{
			get
			{
				return libraryId;
			}
			set	
			{
				libraryId = value;
				DictionaryUtil.Add(QueryParameters, "LibraryId", value);
			}
		}

		public string StoreName
		{
			get
			{
				return storeName;
			}
			set	
			{
				storeName = value;
				DictionaryUtil.Add(QueryParameters, "StoreName", value);
			}
		}

		public string TimeLineUnit
		{
			get
			{
				return timeLineUnit;
			}
			set	
			{
				timeLineUnit = value;
				DictionaryUtil.Add(QueryParameters, "TimeLineUnit", value);
			}
		}

		public string FilterBy
		{
			get
			{
				return filterBy;
			}
			set	
			{
				filterBy = value;
				DictionaryUtil.Add(QueryParameters, "FilterBy", value);
			}
		}

		public string Direction
		{
			get
			{
				return direction;
			}
			set	
			{
				direction = value;
				DictionaryUtil.Add(QueryParameters, "Direction", value);
			}
		}

		public string Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
				DictionaryUtil.Add(QueryParameters, "Order", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListTimeLinesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ListTimeLinesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}