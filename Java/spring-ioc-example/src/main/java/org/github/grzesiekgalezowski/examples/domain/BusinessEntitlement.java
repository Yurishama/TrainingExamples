package org.github.grzesiekgalezowski.examples.domain;

import org.github.grzesiekgalezowski.examples.config.Cache;

public class BusinessEntitlement implements Entitlement {
  public BusinessEntitlement(final Cache cache,
                             final Output output,
                             final String str) {
    System.out.println(this.getClass() + ": ");
    System.out.println("-> " + cache.getClass());
    System.out.println("-> " + output.getClass());
    System.out.println("-> " + str);

  }
}
