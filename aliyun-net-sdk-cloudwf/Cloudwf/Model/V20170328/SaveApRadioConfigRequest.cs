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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class SaveApRadioConfigRequest : RpcAcsRequest<SaveApRadioConfigResponse>
    {
        public SaveApRadioConfigRequest()
            : base("cloudwf", "2017-03-28", "SaveApRadioConfig", "cloudwf", "openAPI")
        {
        }

		private string requireMode;

		private string htmode;

		private int? frag;

		private int? minrate;

		private int? mcastRate;

		private int? probereq;

		private int? channel;

		private int? shortgi;

		private string hwmode;

		private int? uapsd;

		private int? beaconInt;

		private string mac;

		private string accessKeyId;

		private int? rts;

		private int? txpower;

		private int? noscan;

		private int? bcastRate;

		private int? disabled;

		private int? instantlyEffective;

		private long? id;

		private int? radioIndex;

		public string RequireMode
		{
			get
			{
				return requireMode;
			}
			set	
			{
				requireMode = value;
				DictionaryUtil.Add(QueryParameters, "RequireMode", value);
			}
		}

		public string Htmode
		{
			get
			{
				return htmode;
			}
			set	
			{
				htmode = value;
				DictionaryUtil.Add(QueryParameters, "Htmode", value);
			}
		}

		public int? Frag
		{
			get
			{
				return frag;
			}
			set	
			{
				frag = value;
				DictionaryUtil.Add(QueryParameters, "Frag", value.ToString());
			}
		}

		public int? Minrate
		{
			get
			{
				return minrate;
			}
			set	
			{
				minrate = value;
				DictionaryUtil.Add(QueryParameters, "Minrate", value.ToString());
			}
		}

		public int? McastRate
		{
			get
			{
				return mcastRate;
			}
			set	
			{
				mcastRate = value;
				DictionaryUtil.Add(QueryParameters, "McastRate", value.ToString());
			}
		}

		public int? Probereq
		{
			get
			{
				return probereq;
			}
			set	
			{
				probereq = value;
				DictionaryUtil.Add(QueryParameters, "Probereq", value.ToString());
			}
		}

		public int? Channel
		{
			get
			{
				return channel;
			}
			set	
			{
				channel = value;
				DictionaryUtil.Add(QueryParameters, "Channel", value.ToString());
			}
		}

		public int? Shortgi
		{
			get
			{
				return shortgi;
			}
			set	
			{
				shortgi = value;
				DictionaryUtil.Add(QueryParameters, "Shortgi", value.ToString());
			}
		}

		public string Hwmode
		{
			get
			{
				return hwmode;
			}
			set	
			{
				hwmode = value;
				DictionaryUtil.Add(QueryParameters, "Hwmode", value);
			}
		}

		public int? Uapsd
		{
			get
			{
				return uapsd;
			}
			set	
			{
				uapsd = value;
				DictionaryUtil.Add(QueryParameters, "Uapsd", value.ToString());
			}
		}

		public int? BeaconInt
		{
			get
			{
				return beaconInt;
			}
			set	
			{
				beaconInt = value;
				DictionaryUtil.Add(QueryParameters, "BeaconInt", value.ToString());
			}
		}

		public string Mac
		{
			get
			{
				return mac;
			}
			set	
			{
				mac = value;
				DictionaryUtil.Add(QueryParameters, "Mac", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public int? Rts
		{
			get
			{
				return rts;
			}
			set	
			{
				rts = value;
				DictionaryUtil.Add(QueryParameters, "Rts", value.ToString());
			}
		}

		public int? Txpower
		{
			get
			{
				return txpower;
			}
			set	
			{
				txpower = value;
				DictionaryUtil.Add(QueryParameters, "Txpower", value.ToString());
			}
		}

		public int? Noscan
		{
			get
			{
				return noscan;
			}
			set	
			{
				noscan = value;
				DictionaryUtil.Add(QueryParameters, "Noscan", value.ToString());
			}
		}

		public int? BcastRate
		{
			get
			{
				return bcastRate;
			}
			set	
			{
				bcastRate = value;
				DictionaryUtil.Add(QueryParameters, "BcastRate", value.ToString());
			}
		}

		public int? Disabled
		{
			get
			{
				return disabled;
			}
			set	
			{
				disabled = value;
				DictionaryUtil.Add(QueryParameters, "Disabled", value.ToString());
			}
		}

		public int? InstantlyEffective
		{
			get
			{
				return instantlyEffective;
			}
			set	
			{
				instantlyEffective = value;
				DictionaryUtil.Add(QueryParameters, "InstantlyEffective", value.ToString());
			}
		}

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
			}
		}

		public int? RadioIndex
		{
			get
			{
				return radioIndex;
			}
			set	
			{
				radioIndex = value;
				DictionaryUtil.Add(QueryParameters, "RadioIndex", value.ToString());
			}
		}

        public override SaveApRadioConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveApRadioConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
